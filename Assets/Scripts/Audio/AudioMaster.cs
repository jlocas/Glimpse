using UnityEngine;
using System.Collections;
using LibPDBinding;


public class AudioMaster : MonoBehaviour {

	bool[] masterToggleArray = new bool[2]{true,false};
	public bool masterToggle = true;
	float[] masterMulArray = new float[2]{0,0};
	[Range(0.0f,1.0f)]
	public float masterMul = 0.0F;

	int startCount = 0;


	public AudioControls audioControls;
	public LibPDControls libpdControls;
	public Wind wind;
	public Crickets crickets;


	public void MasterLine(float lineTime)
	{
		LibPD.SendFloat("Master_lineTime", lineTime);
	}

	public void SetMasterMul(float mul){
		masterMul = mul;
	}

	public void MasterMul(){
		masterMulArray[0] = masterMul;
		
		if(masterMulArray[0] != masterMulArray[1]){
			LibPD.SendFloat("Master_mul", masterMul);
		}
		masterMulArray[1] = masterMulArray[0];
	}

	public void MasterToggle(){
		
		masterToggleArray[0] = masterToggle;
		
		if (masterToggleArray[0] != masterToggleArray[1] && masterToggleArray[0] == true){
			LibPD.SendFloat ("Master_toggle", 1.0F);
		} else if (masterToggleArray[0] != masterToggleArray[1] && masterToggleArray[0] == false){
			LibPD.SendFloat ("Master_toggle", 0.0F);
		}
		masterToggleArray[1] = masterToggleArray[0];
		masterToggle = masterToggleArray[0];
	}


	public void Start(){

		libpdControls.Update();
		libpdControls.Start ();
		wind.Update();
		crickets.Update();
		audioControls.Update();

		MasterLine(2000.0F);
		masterMul = 0.0f;
		masterToggle = true;

	}

	public void Update(){

		MasterToggle();
		MasterMul();

		libpdControls.Update ();
		audioControls.Update();
	}

}
