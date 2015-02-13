using UnityEngine;
using System.Collections;
using LibPDBinding;

public class LevelProgress: MonoBehaviour {

	public GlimpseCamera glimpseCam;
	
	public int area;
	float[] glimpseDistance = new float[2];
	int glimpsingIn = 0;
	int countFrames = 0;

	public int glimpsesDone;
	
	AudioHighPassFilter[] wf2Hpf;

	void AttachScript(){
		GameObject[] triggers = new GameObject[5];

		for (int i = 0; i < triggers.Length; i++) 
		{
			triggers [i] = GameObject.Find (string.Format ("LevelProgress/Trigger_{0}", i + 1));
			triggers[i].AddComponent("AreaTriggers");
		}
	}
	
	void GlimpseDistance(){
		glimpseDistance[0] = glimpseCam.glimpseDistance;
		
		if(glimpseDistance[1] - glimpseDistance[0] > 0.05 || glimpseDistance[0] - glimpseDistance[1] > 0.05)
		{
			LibPD.SendFloat ("glimpse_distance", glimpseCam.glimpseDistance);
		}

		if(glimpseDistance[0] > 0.0 && area == 3 && wf2Hpf[0].cutoffFrequency < 8000.0f)
		{
			wf2Hpf[0].cutoffFrequency += Time.deltaTime * 15000.0F;
			wf2Hpf[1].cutoffFrequency += Time.deltaTime * 15000.0F;

		} else if(glimpseDistance[0] == 0.0 && wf2Hpf[0].cutoffFrequency > 10.0)
		{
			wf2Hpf[0].cutoffFrequency -= Time.deltaTime * 30000.0F;
			wf2Hpf[1].cutoffFrequency -= Time.deltaTime * 30000.0F;
		}

		glimpseDistance[1] = glimpseDistance[0];
	}

	void GlimpsingIn(){

		if (glimpseCam.glimpsingIn == true && glimpseCam.interpolationOn == true && glimpsingIn != 1) {
			glimpsingIn = 1;
			LibPD.SendFloat("glimpse_glimpsingIn", glimpsingIn);
		}
		if(glimpseCam.interpolationOn == false && glimpsingIn != 0){
			glimpsingIn = 0;
			LibPD.SendFloat("glimpse_glimpsingIn", glimpsingIn);
			}
		}

	public void SetArea(int a){
		area = a;
		LibPD.SendFloat("glimpse_area", a);
	}

	public void SetGlimpseCount(int gcount){
		glimpsesDone = gcount;
		LibPD.SendFloat("glimpse_glimpsesDone", gcount);
	}
	
	// Use this for initialization
	void Start () {
		LibPD.SendBang("music_clock_resetClock");
		LibPD.SendBang("music_clock_reset");
		area = 0;
		AttachScript ();
		wf2Hpf = GameObject.Find("Water/WaterFall_02/Waterfall_Audio").GetComponentsInChildren<AudioHighPassFilter>();

	}
	
	// Update is called once per frame
	void Update () {


		countFrames += 1;

		GlimpsingIn ();

		if (countFrames % 15 == 0) {
			GlimpseDistance ();
		}
	}
}
