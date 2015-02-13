using UnityEngine;
using System.Collections;
using LibPDBinding;

[System.Serializable]
public class AreaTriggers : MonoBehaviour {


	public LevelProgress lvlProg;
	public int area = 0;
	public int[] areas = new int[2]{0, 1}; // 0 new, 1 old
	int a = 1;
	

	void Awake(){
		lvlProg = GameObject.Find("Sound").GetComponent<LevelProgress>();
	}

	int OnTriggerEnter(Collider other){

		switch(collider.name)
		{
		case "Trigger_1":
			if (areas [0] < areas [1]) {
				areas [1] = areas [0];
				areas [0] = 1;
			} else {
				areas [1] = areas [0];
				areas [0] = 0;
			}
			area = areas [0];
			break;

		case "Trigger_2":
			areas[0] = (a % 2) + 1;
			area = areas[0];
			a += 1;
			break;

		case "Trigger_3":
			if (areas [0] < areas [1]) {
				areas [1] = areas [0];
				areas [0] = 3;
			} else {
				areas [1] = areas [0];
				areas [0] = 2;
			}
			area = areas [0];
			break;

		case "Trigger_4":
			if (areas [0] < areas [1]) {
				areas [1] = areas [0];
				areas [0] = 4;
			} else {
				areas [1] = areas [0];
				areas [0] = 3;
			}
			area = areas [0];
			break;

		case "Trigger_5":
			if (areas [0] < areas [1]) {
				areas [1] = areas [0];
				areas [0] = 5;
			} else {
				areas [1] = areas [0];
				areas [0] = 4;
			}
			area = areas [0];
			break;

		}
		lvlProg.SetArea(area);
		return area;
	}


	void OnTriggerExit(Collider other){
		if (collider.name == "Trigger_3") {
			area = areas[1];
			LibPD.SendFloat("glimpse_area", area);
		}
		if (collider.name == "Trigger_5") {
			area = areas[1];
			LibPD.SendFloat("glimpse_area", area);
		}
	}
}

