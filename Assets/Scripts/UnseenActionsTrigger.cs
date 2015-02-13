using UnityEngine;
using System.Collections;

public class UnseenActionsTrigger : MonoBehaviour {

	AudioClips clips;
	AudioPlayer audioplayer;
	GameObject player;
	float distance;

	GameObject fxSource;
	int i;

	public void DollParticles(float emit){
		distance = Vector3.Distance(player.transform.position, gameObject.transform.position);
		
		if (distance < audio.maxDistance && gameObject.GetComponentInChildren<ParticleSystem>() != null)
		{
			ParticleSystem[] dollEyes = gameObject.GetComponentsInChildren<ParticleSystem>();

			foreach(ParticleSystem eyes in dollEyes)
			{
				eyes.emissionRate = emit;
			}
		}
	}

	public void PlayUnseenSound() {

		int sound = Random.Range (0, 5);
		float volume = 0.6f;
		float fxVolume = 0.3F;
		distance = Vector3.Distance(player.transform.position, gameObject.transform.position);

		if(distance < audio.maxDistance)
		{
			switch(sound)
			{
				
			case 0:
				i = Random.Range(0, clips.dollsBoo.Length);
				
				audioplayer.Play(clips.DollsBoo(i), gameObject, 1, 0.0F, volume);
				
				audioplayer.Play(clips.DollsBooFX(i), fxSource, 2, 0.0F, fxVolume);
				
				break;
			case 1:
				i = Random.Range(0, clips.dollsCackle.Length);
				
				audioplayer.Play(clips.DollsCackle(i), gameObject, 1, 0.0F, volume);
				gameObject.audio.volume -= volume;
				
				audioplayer.Play(clips.DollsCackleFX(i), fxSource, 2, 0.0F, fxVolume);
				
				break;
			case 2:
				i = Random.Range(0, clips.dollsGasp.Length);
				
				audioplayer.Play(clips.DollsGasp(i), gameObject, 1, 0.0F, volume);
				gameObject.audio.volume -= volume;
				
				audioplayer.Play(clips.DollsGaspFX(i), fxSource, 2, 0.0F, fxVolume);
				
				break;
			case 3:
				i = Random.Range(0, clips.dollsGiggle.Length);
				
				audioplayer.Play(clips.DollsGiggle(i), gameObject, 1, 0.0F, volume);
				gameObject.audio.volume -= volume;
				
				audioplayer.Play(clips.DollsGiggleFX(i), fxSource, 2, 0.0F, fxVolume);
				
				break;
			case 4:
				i = Random.Range(0, clips.dollsShush.Length);
				
				audioplayer.Play(clips.DollsShush(i), gameObject, 1, 0.0F, volume);
				gameObject.audio.volume -= volume;
				
				audioplayer.Play(clips.DollsShushFX(i), fxSource, 2, 0.0F, fxVolume);
				
				break;
			case 5:
				i = Random.Range(0, clips.dollsWhispers.Length);
				
				audioplayer.Play(clips.DollsWhispers(i), gameObject, 1, 0.0F, volume);
				gameObject.audio.volume -= volume;
				
				audioplayer.Play(clips.DollsWhispers(i), fxSource, 2, 0.0F, fxVolume);
				
				break;
			}
		}

	}

	public void Start(){
		clips = GameObject.Find("Sound").GetComponent<AudioClips>();
		audioplayer = GameObject.Find("Sound").GetComponent<AudioPlayer>();
		fxSource = GameObject.Find ("Sound/Dolls_FX");
		player = GameObject.Find("Player");

	}
}
