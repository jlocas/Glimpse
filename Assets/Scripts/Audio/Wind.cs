﻿using UnityEngine;
using System.Collections;
using LibPDBinding;

[System.Serializable]
public class Wind {

	//wind parameters
	float wind_BG_freqBase = 100.0F;
	public float Wind_BG_freqBase {
		get {
			return wind_BG_freqBase;
		}
		set {
			wind_BG_freqBase = value;
			Update();
		}
	}
	
	float wind_BG_freqAmbitus = 200.0F;
	public float Wind_BG_freqAmbitus {
		get {
			return wind_BG_freqAmbitus;
		}
		set {
			wind_BG_freqAmbitus = value;
			Update();
		}
	}
	
	float wind_BG_Q = 10.0F;
	public float Wind_BG_Q {
		get {
			return wind_BG_Q;
		}
		set {
			wind_BG_Q = value;
			Update();
		}
	}
	
	float wind_BG_hpfFreq = 100.0F;
	public float Wind_BG_hpfFreq {
		get {
			return wind_BG_hpfFreq;
		}
		set {
			wind_BG_hpfFreq = value;
			Update();
		}
	}

	[SerializeField]
	float wind_BG_noiseAdd = 0.05F;
	public float Wind_BG_noiseAdd {
		get {
			return wind_BG_noiseAdd;
		}
		set {
			wind_BG_noiseAdd = value;
			Update();
		}
	}

	[SerializeField]
	float wind_BG_bp1Freq = 200.0F;
	public float Wind_BG_bp1Freq {
		get {
			return wind_BG_bp1Freq;
		}
		set {
			wind_BG_bp1Freq = value;
			Update();
		}
	}

	[SerializeField]
	float wind_BG_bp1Q = 1.0F;
	public float Wind_BG_bp1Q {
		get {
			return wind_BG_bp1Q;
		}
		set {
			wind_BG_bp1Q = value;
			Update();
		}
	}

	[SerializeField]
	float wind_BG_bp1Mul = 0.0F;
	public float Wind_BG_bp1Mul {
		get {
			return wind_BG_bp1Mul;
		}
		set {
			wind_BG_bp1Mul = value;
			Update();
		}
	}

	[SerializeField]
	float wind_BG_bp2Freq = 400.0F;
	public float Wind_BG_bp2Freq {
		get {
			return wind_BG_bp2Freq;
		}
		set {
			wind_BG_bp2Freq = value;
			Update();
		}
	}

	[SerializeField]
	float wind_BG_bp2Q = 10.0F;
	public float Wind_BG_bp2Q {
		get {
			return wind_BG_bp2Q;
		}
		set {
			wind_BG_bp2Q = value;
			Update();
		}
	}

	[SerializeField]
	float wind_BG_bp2Mul = 1.0F;
	public float Wind_BG_bp2Mul {
		get {
			return wind_BG_bp2Mul;
		}
		set {
			wind_BG_bp2Mul = value;
			Update();
		}
	}

	[SerializeField]
	float wind_BG_bp3Freq = 1600.0F;
	public float Wind_BG_bp3Freq {
		get {
			return wind_BG_bp3Freq;
		}
		set {
			wind_BG_bp3Freq = value;
			Update();
		}
	}

	[SerializeField]
	float wind_BG_bp3Q = 5.0F;
	public float Wind_BG_bp3Q {
		get {
			return wind_BG_bp3Q;
		}
		set {
			wind_BG_bp3Q = value;
			Update();
		}
	}

	[SerializeField]
	float wind_BG_bp3Mul = 1.0F;
	public float Wind_BG_bp3Mul {
		get {
			return wind_BG_bp3Mul;
		}
		set {
			wind_BG_bp3Mul = value;
			Update();
		}
	}

	[SerializeField]
	float wind_BG_mul = 1.0F;
	public float Wind_BG_mul {
		get {
			return wind_BG_mul;
		}
		set {
			wind_BG_mul = value;
			Update();
		}
	}

	[SerializeField]
	float wind_WH_freqBase = 100.0F;
	public float Wind_WH_freqBase {
		get {
			return wind_WH_freqBase;
		}
		set {
			wind_WH_freqBase = value;
			Update();
		}
	}

	[SerializeField]
	float wind_WH_freqAmbitus = 500.0F;
	public float Wind_WH_freqAmbitus {
		get {
			return wind_WH_freqAmbitus;
		}
		set {
			wind_WH_freqAmbitus = value;
			Update();
		}
	}

	[SerializeField]
	float wind_WH_Q = 500.0F;
	public float Wind_WH_Q {
		get {
			return wind_WH_Q;
		}
		set {
			wind_WH_Q = value;
			Update();
		}
	}

	[SerializeField]
	float wind_WH_add = 0.0F;
	public float Wind_WH_add {
		get {
			return wind_WH_add;
		}
		set {
			wind_WH_add = value;
			Update();
		}
	}

	[SerializeField]
	float wind_WH_mul = 0.5F;
	public float Wind_WH_mul {
		get {
			return wind_WH_mul;
		}
		set {
			wind_WH_mul = value;
			Update();
		}
	}

	[SerializeField]
	float wind_WH_octRatio = 2.0F;
	public float Wind_WH_octRatio {
		get {
			return wind_WH_octRatio;
		}
		set {
			wind_WH_octRatio = value;
			Update();
		}
	}

	[SerializeField]
	float wind_WH_octDamp = 1.0F;
	public float Wind_WH_octDamp {
		get {
			return wind_WH_octDamp;
		}
		set {
			wind_WH_octDamp = value;
			Update();
		}
	}

	[SerializeField]
	float wind_WH_randVal = 0.0F;
	public float Wind_WH_randVal {
		get {
			return wind_WH_randVal;
		}
		set {
			wind_WH_randVal = value;
			Update();
		}
	}

	[SerializeField]
	float wind_leaves_mul = 0.15F;
	public float Wind_leaves_mul {
		get {
			return wind_leaves_mul;
		}
		set {
			wind_leaves_mul = value;
			Update();
		}
	}
	
	//wind DSP
	[SerializeField]
	float wind_reverb_dryWet = 0.8F;
	public float Wind_reverb_dryWet {
		get {
			return wind_reverb_dryWet;
		}
		set {
			wind_reverb_dryWet = value;
			Update();
		}
	}

	//windspeed
	[SerializeField]
	float max = 0.3F;
	public float Max {
		get {
			return max;
		}
		set {
			max = value;
			Update();
		}
	}
	
	//windspeed
	[SerializeField]
	float min;
	public float Min {
		get {
			return min;
		}
		set {
			min = value;
			Update();
		}
	}
	
	public void Update() {
		if (Application.isPlaying) {
			LibPD.SendFloat("wind_BG_freqBase", Wind_BG_freqBase);
			LibPD.SendFloat("wind_BG_freqAmbitus", Wind_BG_freqAmbitus);
			LibPD.SendFloat("wind_BG_Q", Wind_BG_Q);
			LibPD.SendFloat("wind_BG_hpfFreq", Wind_BG_hpfFreq);
			LibPD.SendFloat("wind_BG_noiseAdd", Wind_BG_noiseAdd);
			LibPD.SendFloat("wind_BG_bp1Freq", Wind_BG_bp1Freq);
			LibPD.SendFloat("wind_BG_bp1Q", Wind_BG_bp1Q);
			LibPD.SendFloat("wind_BG_bp1Mul", Wind_BG_bp1Mul);
			LibPD.SendFloat("wind_BG_bp2Freq", Wind_BG_bp2Freq);
			LibPD.SendFloat("wind_BG_bp2Q", Wind_BG_bp2Q);
			LibPD.SendFloat("wind_BG_bp2Mul", Wind_BG_bp2Mul);
			LibPD.SendFloat("wind_BG_bp3Freq", Wind_BG_bp3Freq);
			LibPD.SendFloat("wind_BG_bp3Q", Wind_BG_bp3Q);
			LibPD.SendFloat("wind_BG_bp3Mul", Wind_BG_bp3Mul);
			LibPD.SendFloat("wind_BG_mul", Wind_BG_mul);
			LibPD.SendFloat("wind_WH_freqBase", Wind_WH_freqBase);
			LibPD.SendFloat("wind_WH_freqAmbitus", Wind_WH_freqAmbitus);
			LibPD.SendFloat("wind_WH_Q", Wind_WH_Q);
			LibPD.SendFloat("wind_WH_add", Wind_WH_add);
			LibPD.SendFloat("wind_WH_mul", Wind_WH_mul);
			LibPD.SendFloat("wind_WH_octRatio", Wind_WH_octRatio);
			LibPD.SendFloat("wind_WH_octDamp", Wind_WH_octDamp);
			LibPD.SendFloat("wind_WH_randVal", Wind_WH_randVal);
			LibPD.SendFloat("wind_leaves_mul", Wind_leaves_mul);
			LibPD.SendFloat("wind_reverb_dry-wet", Wind_reverb_dryWet);

			//windspeed
			LibPD.SendFloat("wind_speed_max", Max);
			LibPD.SendFloat("wind_speed_min", Min);
		}


	}
}

