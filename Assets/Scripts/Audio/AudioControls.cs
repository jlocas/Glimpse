using UnityEngine;
using System.Collections;

[System.Serializable]
public class AudioControls{

	public AudioSource[] waterfall1 = new AudioSource[2];
	public AudioSource[] waterfall2 = new AudioSource[2];

	bool[] wf1ToggleArray = new bool[2];
	bool[] wf2ToggleArray = new bool[2];

	public bool waterfall1Toggle = true;
	public bool waterfall2Toggle = true;

	float[] wf1MulArray = new float[2]{0,0};
	float[] wf2MulArray = new float[2]{0,0};

	[Range(0.0f,1.0f)]
	public float wf1Mul = 1.0F;
	[Range(0.0f,1.0f)]
	public float wf2Mul = 1.0F;

	void WF1Toggle(){
		
		wf1ToggleArray[0] = waterfall1Toggle;
		
		if (wf1ToggleArray[0] != wf1ToggleArray[1] && wf1ToggleArray[0] == true){
			waterfall1[0].Play();
			waterfall1[1].Play();
		} else if (wf1ToggleArray[0] != wf1ToggleArray[1] && wf1ToggleArray[0] == false){
			waterfall1[0].Stop();
			waterfall1[1].Stop();
		}
		wf1ToggleArray[1] = wf1ToggleArray[0];
		waterfall1Toggle = wf1ToggleArray[0];
	}

	void WF1Mul(){
		wf1MulArray[0] = wf1Mul;
		
		if(wf1MulArray[0] != wf1MulArray[1]){
			waterfall1[0].audio.volume = wf1Mul * 0.5f;
			waterfall1[1].audio.volume = wf1Mul;
		}
		wf1MulArray[1] = wf1MulArray[0];
	}

	void WF2Toggle(){
		
		wf2ToggleArray[0] = waterfall2Toggle;
		
		if (wf2ToggleArray[0] != wf2ToggleArray[1] && wf2ToggleArray[0] == true){
			waterfall2[0].Play();
			waterfall2[1].Play();
		} else if (wf2ToggleArray[0] != wf2ToggleArray[1] && wf2ToggleArray[0] == false){
			waterfall2[0].Stop();
			waterfall2[1].Stop();
		}
		wf2ToggleArray[1] = wf2ToggleArray[0];
		waterfall2Toggle = wf2ToggleArray[0];
	}
	
	void WF2Mul(){
		wf2MulArray[0] = wf2Mul;
		
		if(wf2MulArray[0] != wf2MulArray[1]){
			waterfall2[0].audio.volume = wf2Mul * 0.5f;
			waterfall2[1].audio.volume = wf2Mul;
		}
		wf2MulArray[1] = wf2MulArray[0];
	}


	// Use this for initialization
	public void Update () {
		WF1Toggle ();
		WF2Toggle ();

		WF1Mul ();
		WF2Mul ();
	}

}
