using UnityEngine;
using System.Collections;

public class Slide : MonoBehaviour {

	public PlayerMove playerMove;
	FloorTexture floor;

	[Range(0.0f, 1.0f)]
	public float volume = 1.0f;
	public AudioClip[] stoneSlide;
	public float fadeOutTime = 1.0F;
	bool[] slideStatus = new bool[2]{false,false};

	bool fadingOut;

	void StoneSlide()
	{
		slideStatus[0] = playerMove.sliding;
		
		if(slideStatus[0] == true && slideStatus[1] == false && playerMove.hasLanded == false && floor.DetectColliders(gameObject.transform) == false)
		{
			audio.volume = volume;
			audio.loop = true;
			audio.clip = stoneSlide[0];
			audio.timeSamples = Random.Range (0, audio.clip.samples);
			audio.Play();
			slideStatus[1] = slideStatus[0];

		} else if (slideStatus[1] == true && slideStatus[0] == false)
		{
			audio.clip = stoneSlide[0];
			fadingOut = true;
			slideStatus[1] = slideStatus[0];
		}
	}

	void FadeOut()
	{
		if(audio.volume > 0.0F && fadingOut == true)
		{
			audio.volume -= fadeOutTime * Time.deltaTime;
		} else if (audio.volume == 0.0F){
			fadingOut = false;
			audio.loop = false;
		}

	}

	// Use this for initialization
	void Start () {
		audio.volume = 0.0F;
		floor = GameObject.Find("Sound").GetComponent<FloorTexture>();
	
	}
	
	// Update is called once per frame
	void Update () {
		FadeOut();
		StoneSlide();

	
	}
}
