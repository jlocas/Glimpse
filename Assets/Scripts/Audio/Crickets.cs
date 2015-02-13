using UnityEngine;
using System.Collections;
using LibPDBinding;

[System.Serializable]
public class Crickets {

	[SerializeField]
	float crickets1_mul = 0.3F;
	public float Crickets1_mul {
		get {
			return crickets1_mul;
		}
		set {
			crickets1_mul = value;
			Update();
		}
	}

	[SerializeField]
	float crickets2_mul = 0.1F;
	public float Crickets2_mul {
		get {
			return crickets2_mul;
		}
		set {
			crickets2_mul = value;
			Update();
		}
	}

	[SerializeField]
	float crickets_reverb_dryWet = 0.7F;
	public float Crickets_reverb_dryWet {
		get {
			return crickets_reverb_dryWet;
		}
		set {
			crickets_reverb_dryWet = value;
			Update();
		}
	}
	
	public void Update() {
		if (Application.isPlaying) {
			LibPD.SendFloat("crickets1_mul", Crickets1_mul);
			LibPD.SendFloat("crickets2_mul", Crickets2_mul);
			LibPD.SendFloat("crickets_reverb_dry-wet", Crickets_reverb_dryWet);
		}
	}
}
