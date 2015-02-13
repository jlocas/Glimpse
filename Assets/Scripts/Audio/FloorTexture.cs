using UnityEngine;
using System.Collections;

[System.Serializable]
public class FloorTexture : MonoBehaviour {


	//variables to read the Terrain texture
	int surfaceIndex;
	public Terrain terrain;
	TerrainData terrainData; 
	Vector3 terrainPos;

	RaycastHit hitInfo;
	float raycastDist = 15.0F;

	string surface = "Dirt";
	public string terrainType;
	
	public bool inWater = false;

	

	void Start () {
		terrainData = terrain.terrainData; 
		terrainPos = terrain.transform.position;
	}

	public float[] GetTextureMix(Vector3 worldPos)
	{
		// returns an array containing the relative mix of textures
		// on the main terrain at this world position.
		
		// The number of values in the array will equal the number
		// of textures added to the terrain.

		// calculate which splat map cell the worldPos falls within (ignoring y)
		int mapX = (int)(((worldPos.x - terrainPos.x) / terrainData.size.x) * terrainData.alphamapWidth);
		int mapZ = (int)(((worldPos.z - terrainPos.z) / terrainData.size.z) * terrainData.alphamapWidth);

		// get the splat data for this cell as a 1x1xN 3d array (where N = number of textures)
		float[,,] splatmapData = terrainData.GetAlphamaps(mapX, mapZ, 1, 1);

		// extract the 3D array data to a 1D array:
		float[] cellMix = new float[splatmapData.GetUpperBound(2) + 1];

		for (int i = 0; i < cellMix.Length; i++)
		{
			cellMix[i] = splatmapData[0, 0, i];
		}

		return cellMix;
	}

	public int GetMainTexture(Vector3 worldPos)
	{
		// returns the zero-based index of the most dominant texture
		// on the main terrain at this world position.
		float[] mix = GetTextureMix(worldPos);

		float maxMix = 0;
		int maxIndex = 0;

		// loop through each mix value and find the maximum
		for(int i = 0; i < mix.Length; i++)
		{
			if (mix[i] > maxMix)
			{
				maxIndex = i;
				maxMix = mix[i];
			}
		}

		return maxIndex;
	}

	
	public void SetInWater(bool a)
	{
		inWater = a;
	}


	string GetSurface(Vector3 worldPos)
	{
		surfaceIndex = GetMainTexture(worldPos);

		if(surfaceIndex == 1 || surfaceIndex == 5 || surfaceIndex == 6 || surfaceIndex == 7){
			surface = "Grass";
		} else if (surfaceIndex == 3 || surfaceIndex == 10){
			surface = "Dirt";
		}
		return surface;
	}

	public bool DetectColliders(Transform transform)
	{
		bool foundHit = false;
		
		if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hitInfo, raycastDist))
		{
			if(hitInfo.collider.tag != "Terrain"){
				foundHit = true;
			} else {
				foundHit = false;
			}
		}
		return foundHit;
	}


	public string ReadTexture(Transform player)
	{
		string surface;

		if(DetectColliders(player) == true)
		{
			surface = hitInfo.collider.tag;
		} else if(inWater == true){
			surface = "Water";
		} else {
			surface = GetSurface(player.position);
		}
		//Debug.Log(surface);
		terrainType = surface;
		return surface;
	}

}

