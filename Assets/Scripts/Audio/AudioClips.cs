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
			i = Random.Range(0, dollsAhemFX.Length);
		}
		
		AudioClip clip = dollsAhemFX[i];
		return clip;
	}
	
	public AudioClip DollsBooFX(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsBooFX.Length);
		}
		
		AudioClip clip = dollsBooFX[i];
		return clip;
	}
	
	public AudioClip DollsCackleFX(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsCackleFX.Length);
		}
		
		AudioClip clip = dollsCackleFX[i];
		return clip;
	}
	
	public AudioClip DollsGaspFX(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsGaspFX.Length);
		}
		
		AudioClip clip = dollsGaspFX[i];
		return clip;
	}
	
	public AudioClip DollsGiggleFX(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsGiggleFX.Length);
		}
		
		AudioClip clip = dollsGiggleFX[i];
		return clip;
	}
	
	public AudioClip DollsOopsFX(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsOopsFX.Length);
		}
		
		AudioClip clip = dollsOopsFX[i];
		return clip;
	}
	
	public AudioClip DollsShushFX(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsShushFX.Length);
		}
		
		AudioClip clip = dollsShushFX[i];
		return clip;
	}
	
	public AudioClip DollsUhOhFX(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsUhOhFX.Length);
		}
		
		AudioClip clip = dollsUhOhFX[i];
		return clip;
	}
	
	public AudioClip DollsWhispersFX(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsWhispersFX.Length);
		}
		
		AudioClip clip = dollsWhispersFX[i];
		return clip;
	}


	public AudioClip DollsAhem(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsAhem.Length);
		}

		AudioClip clip = dollsAhem[i];
		return clip;
	}

	public AudioClip DollsBoo(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsBoo.Length);
		}
		
		AudioClip clip = dollsBoo[i];
		return clip;
	}

	public AudioClip DollsCackle(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsCackle.Length);
		}
		
		AudioClip clip = dollsCackle[i];
		return clip;
	}

	public AudioClip DollsGasp(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsGasp.Length);
		}
		
		AudioClip clip = dollsGasp[i];
		return clip;
	}

	public AudioClip DollsGiggle(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsGiggle.Length);
		}
		
		AudioClip clip = dollsGiggle[i];
		return clip;
	}

	public AudioClip DollsOops(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsOops.Length);
		}
		
		AudioClip clip = dollsOops[i];
		return clip;
	}

	public AudioClip DollsShush(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsShush.Length);
		}
		
		AudioClip clip = dollsShush[i];
		return clip;
	}

	public AudioClip DollsUhOh(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsUhOh.Length);
		}
		
		AudioClip clip = dollsUhOh[i];
		return clip;
	}

	public AudioClip DollsWhispers(int i = -1)
	{
		if (i == -1)
		{
			i = Random.Range(0, dollsWhispers.Length);
		}
		
		AudioClip clip = dollsWhispers[i];
		return clip;
	}


	public AudioClip DirtRun()
	{
		AudioClip clip = dirtRun[Random.Range(0, dirtRun.Length)];
		return clip;
	}
	
	public AudioClip DirtWalk()
	{
		AudioClip clip = dirtWalk[Random.Range(0, dirtWalk.Length)];
		return clip;
	}
	
	public AudioClip DirtJump()
	{
		AudioClip clip = dirtJump[Random.Range(0, dirtJump.Length)];
		return clip;
	}
	
	public AudioClip DirtLand()
	{
		AudioClip clip = dirtLand[Random.Range(0, dirtLand.Length)];
		return clip;
	}
	
	public AudioClip GrassRun()
	{
		AudioClip clip = grassRun[Random.Range(0, grassRun.Length)];
		return clip;
	}
	
	public AudioClip GrassWalk()
	{
		AudioClip clip = grassWalk[Random.Range(0, grassWalk.Length)];
		return clip;
	}
	
	public AudioClip GrassJump()
	{
		AudioClip clip = grassJump[Random.Range(0, grassJump.Length)];
		return clip;
	}
	
	public AudioClip GrassLand()
	{
		AudioClip clip = grassLand[Random.Range(0, grassLand.Length)];
		return clip;
	}
	
	public AudioClip StoneRun()
	{
		AudioClip clip = stoneRun[Random.Range(0, stoneRun.Length)];
		return clip;
	}
	
	public AudioClip StoneWalk()
	{
		AudioClip clip = stoneWalk[Random.Range(0, stoneWalk.Length)];
		return clip;
	}
	
	public AudioClip StoneJump()
	{
		AudioClip clip = stoneJump[Random.Range(0, stoneJump.Length)];
		return clip;
	}
	
	public AudioClip StoneLand()
	{
		AudioClip clip = stoneLand[Random.Range(0, stoneLand.Length)];
		return clip;
	}
	
	public AudioClip WaterWalk()
	{
		AudioClip clip = waterWalk[Random.Range(0, stoneLand.Length)];
		return clip;
	}
}
