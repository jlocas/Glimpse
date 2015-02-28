using UnityEngine;
using System.Collections;

[System.Serializable]
public class AudioClips : MonoBehaviour {

	/*[System.Serializable]
	public class ClipStruct{public AudioClip[] clip; public string category;}
	public Hashtable clipsTable;
	public ClipStruct[] clips;*/

	//public Newclips[] clips;
	//public AudioClip[][] clips;

	public AudioClip[] dollsAhem;
	public AudioClip[] dollsBoo;
	public AudioClip[] dollsCackle;
	public AudioClip[] dollsGasp;
	public AudioClip[] dollsGiggle;
	public AudioClip[] dollsOops;
	public AudioClip[] dollsShush;
	public AudioClip[] dollsUhOh;
	public AudioClip[] dollsWhispers;

	public AudioClip[] dollsAhemFX;
	public AudioClip[] dollsBooFX;
	public AudioClip[] dollsCackleFX;
	public AudioClip[] dollsGaspFX;
	public AudioClip[] dollsGiggleFX;
	public AudioClip[] dollsOopsFX;
	public AudioClip[] dollsShushFX;
	public AudioClip[] dollsUhOhFX;
	public AudioClip[] dollsWhispersFX;

	public AudioClip[] dirtRun;
	public AudioClip[] dirtWalk;
	public AudioClip[] dirtJump;
	public AudioClip[] dirtLand;
	
	public AudioClip[] grassRun;
	public AudioClip[] grassWalk;
	public AudioClip[] grassJump;
	public AudioClip[] grassLand;
	
	public AudioClip[] stoneRun;
	public AudioClip[] stoneWalk;
	public AudioClip[] stoneJump;
	public AudioClip[] stoneLand;
	
	public AudioClip[] waterWalk;

	/*void Start(){
		foreach(ClipStruct c in clips){
			clipsTable.Add(c.category, c.clip);
		}
	}

	public AudioClip PlayClip(string category)
	{
		AudioClip[] categoryClips = clipsTable.
		AudioClip clip = dirtWalk[Random.Range(0, dirtWalk.Length)];
		return clip;
	}*/

	public AudioClip DollsAhemFX(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsAhemFX.Length - 1);
		}
		
		AudioClip clip = dollsAhemFX[i];
		return clip;
	}
	
	public AudioClip DollsBooFX(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsBooFX.Length - 1);
		}
		
		AudioClip clip = dollsBooFX[i];
		return clip;
	}
	
	public AudioClip DollsCackleFX(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsCackleFX.Length - 1);
		}
		
		AudioClip clip = dollsCackleFX[i];
		return clip;
	}
	
	public AudioClip DollsGaspFX(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsGaspFX.Length - 1);
		}
		
		AudioClip clip = dollsGaspFX[i];
		return clip;
	}
	
	public AudioClip DollsGiggleFX(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsGiggleFX.Length - 1);
		}
		
		AudioClip clip = dollsGiggleFX[i];
		return clip;
	}
	
	public AudioClip DollsOopsFX(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsOopsFX.Length - 1);
		}
		
		AudioClip clip = dollsOopsFX[i];
		return clip;
	}
	
	public AudioClip DollsShushFX(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsShushFX.Length - 1);
		}
		
		AudioClip clip = dollsShushFX[i];
		return clip;
	}
	
	public AudioClip DollsUhOhFX(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsUhOhFX.Length - 1);
		}
		
		AudioClip clip = dollsUhOhFX[i];
		return clip;
	}
	
	public AudioClip DollsWhispersFX(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsWhispersFX.Length - 1);
		}
		
		AudioClip clip = dollsWhispersFX[i];
		return clip;
	}


	public AudioClip DollsAhem(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsAhem.Length - 1);
		}

		AudioClip clip = dollsAhem[i];
		return clip;
	}

	public AudioClip DollsBoo(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsBoo.Length - 1);
		}
		
		AudioClip clip = dollsBoo[i];
		return clip;
	}

	public AudioClip DollsCackle(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsCackle.Length - 1);
		}
		
		AudioClip clip = dollsCackle[i];
		return clip;
	}

	public AudioClip DollsGasp(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsGasp.Length - 1);
		}
		
		AudioClip clip = dollsGasp[i];
		return clip;
	}

	public AudioClip DollsGiggle(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsGiggle.Length - 1);
		}
		
		AudioClip clip = dollsGiggle[i];
		return clip;
	}

	public AudioClip DollsOops(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsOops.Length - 1);
		}
		
		AudioClip clip = dollsOops[i];
		return clip;
	}

	public AudioClip DollsShush(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsShush.Length - 1);
		}
		
		AudioClip clip = dollsShush[i];
		return clip;
	}

	public AudioClip DollsUhOh(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsUhOh.Length - 1);
		}
		
		AudioClip clip = dollsUhOh[i];
		return clip;
	}

	public AudioClip DollsWhispers(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsWhispers.Length - 1);
		}
		
		AudioClip clip = dollsWhispers[i];
		return clip;
	}


	public AudioClip DirtRun()
	{
		AudioClip clip = dirtRun[Random.Range(0, dirtRun.Length - 1)];
		return clip;
	}
	
	public AudioClip DirtWalk()
	{
		AudioClip clip = dirtWalk[Random.Range(0, dirtWalk.Length - 1)];
		return clip;
	}
	
	public AudioClip DirtJump()
	{
		AudioClip clip = dirtJump[Random.Range(0, dirtJump.Length - 1)];
		return clip;
	}
	
	public AudioClip DirtLand()
	{
		AudioClip clip = dirtLand[Random.Range(0, dirtLand.Length - 1)];
		return clip;
	}
	
	public AudioClip GrassRun()
	{
		AudioClip clip = grassRun[Random.Range(0, grassRun.Length - 1)];
		return clip;
	}
	
	public AudioClip GrassWalk()
	{
		AudioClip clip = grassWalk[Random.Range(0, grassWalk.Length - 1)];
		return clip;
	}
	
	public AudioClip GrassJump()
	{
		AudioClip clip = grassJump[Random.Range(0, grassJump.Length - 1)];
		return clip;
	}
	
	public AudioClip GrassLand()
	{
		AudioClip clip = grassLand[Random.Range(0, grassLand.Length - 1)];
		return clip;
	}
	
	public AudioClip StoneRun()
	{
		AudioClip clip = stoneRun[Random.Range(0, stoneRun.Length - 1)];
		return clip;
	}
	
	public AudioClip StoneWalk()
	{
		AudioClip clip = stoneWalk[Random.Range(0, stoneWalk.Length - 1)];
		return clip;
	}
	
	public AudioClip StoneJump()
	{
		AudioClip clip = stoneJump[Random.Range(0, stoneJump.Length - 1)];
		return clip;
	}
	
	public AudioClip StoneLand()
	{
		AudioClip clip = stoneLand[Random.Range(0, stoneLand.Length - 1)];
		return clip;
	}
	
	public AudioClip WaterWalk()
	{
		AudioClip clip = waterWalk[Random.Range(0, stoneLand.Length - 1)];
		return clip;
	}
}
