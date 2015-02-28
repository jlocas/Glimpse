using UnityEngine;
using System.Collections;
using LibPDBinding;

public class ScreenFade : MonoBehaviour {

	public AudioMaster audioMaster;

	public float fadeInSpeed = 1.0f;          // Speed that the screen fades to and from black.
	public float fadeOutSpeed = 0.25f;
	public bool start = false;
	public bool end = false;
	public Camera[] cameras;
	public GameObject soundSystems;
	int count = 0;
	
	void Awake ()
	{
		// Set the texture so that it is the the size of the screen and covers it.
		guiTexture.pixelInset = new Rect(0f, 0f, Screen.width, Screen.height);
		guiTexture.color = Color.black;
		audioMaster = GameObject.Find("Sound").GetComponent<AudioMaster>();
	}

	

	void FadeToClear ()
	{
		// Lerp the colour of the texture between itself and transparent.
		guiTexture.color = Color.Lerp(guiTexture.color, Color.clear, fadeInSpeed * Time.deltaTime);
	}

	void FadeToBlack ()
	{
		// Lerp the colour of the texture between itself and black.
		guiTexture.color = Color.Lerp(guiTexture.color, Color.black, fadeOutSpeed * Time.deltaTime);
	}


	// Update is called once per frame
	void Update () {

		if(Input.GetButtonUp("Cancel")){



			Application.LoadLevel(Application.loadedLevel);

			
			
			LibPD.ReInit ();
			
		}

		if(Input.GetButtonUp("Start")){
			count += 1;

			if(count % 2 == 1){
				start = true;
			} else {
				end = true;
			}

			foreach (Camera cameraToGo in cameras) {
				cameraToGo.enabled = false;
			}

		}


		if(start == true){
			FadeToClear();
			audioMaster.SetMasterMul(1.0F);

			if(guiTexture.color.a <= 0.05f){
				guiTexture.color = Color.clear;
				start = false;
				audioMaster.libpdControls.SetMusicToggle(true);
			}
		}

		if(end == true){
			FadeToBlack();
			audioMaster.SetMasterMul(0.0F);
			if(guiTexture.color.a >= 0.95f){
				guiTexture.color = Color.black;
				end = false;
			}
		}
	
	}
}
