using UnityEngine;
using System.Collections;

public class AudioPlayer : MonoBehaviour {
	
	GameObject audioSources;


	//polyphony: 0 = cuts off sound, 1 = play nothing if sound is playing, 2 = layer new sound
	public void Play(AudioClip clip, GameObject source, int polyphony, float pitch = 0.0F, float volume = 0.0F)
	{
		//defaut values
		if(pitch == 0.0F)
		{
			pitch = Random.Range(0.95F, 1.05F);
		}
		if(volume == 0.0F)
		{
			volume = Random.Range(0.9F, 1.0F);
		}
		
		AudioSource[] audioSources = source.GetComponents<AudioSource>();

		
		if(audioSources.Length > 0)
		{
			
			switch(polyphony){
			case 0:
				source.audio.pitch = pitch;
				source.audio.volume = volume;
				source.audio.clip = clip;
				source.audio.Play();
				break;

			case 1:
				for(int i = 0; i < audioSources.Length; i++)
				{
					
					if (audioSources[i].isPlaying == false)
					{
						audioSources[i].pitch = pitch;
						audioSources[i].volume = volume;
						audioSources[i].clip = clip;
						audioSources[i].Play();
						break;
					}
				}
				break;

			case 2:
				bool foundSource = false;

				for(int i = 0; i < audioSources.Length; i++)
				{
					
					if (audioSources[i].isPlaying == false)
					{
						audioSources[i].pitch = pitch;
						audioSources[i].volume = volume;
						audioSources[i].clip = clip;
						audioSources[i].Play();
						foundSource = true;
						break;
					}
				}
				if(foundSource == false)
				{
					source.AddComponent<AudioSource>();
					
					source.audio.pitch = pitch;
					source.audio.volume = volume;
					source.audio.clip = clip;
					source.audio.Play();
					foundSource = true;
				}
				break;
			}
			
		} else {
			source.AddComponent<AudioSource>();
		}
		audioSources =  source.GetComponents<AudioSource>();
		
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
