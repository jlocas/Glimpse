using UnityEngine;
using System.Collections;
using LibPDBinding;


[System.Serializable]
public class LibPDControls {

	bool[] pdToggleArray = new bool[2]{true,false};
	bool[] windToggleArray = new bool[2]{true,false};
	bool[] musicToggleArray = new bool[2]{true,false};
	bool[] cricketsToggleArray = new bool[2]{true,false};
	bool[] glimpsesToggleArray = new bool[2]{true,false};

	public bool pdToggle = true;
	public bool windToggle = true;
	public bool musicToggle = false;
	public bool cricketsToggle = true;
	public bool glimpsesToggle = true;

	float[] pdMulArray = new float[2]{0,0};
	float[] windMulArray = new float[2]{0,0};
	float[] musicMulArray = new float[2]{0,0};
	float[] cricketsMulArray = new float[2]{0,0};
	float[] glimpsesMulArray = new float[2]{0,0};

	[Range(0.0f,15.0f)]
	public float pdMul = 1.0F;
	[Range(0.0f,15.0f)]
	public float windMul = 1.0F;
	[Range(0.0f,15.0f)]
	public float musicMul = 1.0F;
	[Range(0.0f,15.0f)]
	public float cricketsMul = 1.0F;
	[Range(0.0f,15.0f)]
	public float glimpsesMul = 1.0F;
	
	float[] windRvbArray = new float[2]{0,0};
	float[] musicRvbArray = new float[2]{0,0};
	float[] cricketsRvbArray = new float[2]{0,0};

	[Range(0.0f,1.0f)]
	public float windRvb = 0.5F;
	[Range(0.0f,1.0f)]
	public float musicRvb = 0.5F;
	[Range(0.0f,1.0f)]
	public float cricketsRvb = 0.5F;

	void WindRvb(){
		windRvbArray[0] = windRvb;
		
		if(windRvbArray[0] != windRvbArray[1]){
			LibPD.SendFloat("Wind_rvb", windRvb);
		}
		windRvbArray[1] = windRvbArray[0];
	}

	void MusicRvb(){
		musicRvbArray[0] = musicRvb;
		
		if(musicRvbArray[0] != musicRvbArray[1]){
			LibPD.SendFloat("Music_rvb", musicRvb);
		}
		musicRvbArray[1] = musicRvbArray[0];
	}

	void CricketsRvb(){
		cricketsRvbArray[0] = cricketsRvb;
		
		if(cricketsRvbArray[0] != cricketsRvbArray[1]){
			LibPD.SendFloat("Crickets_rvb", cricketsRvb);
		}
		cricketsRvbArray[1] = cricketsRvbArray[0];
	}


	void PDMul(){
		pdMulArray[0] = pdMul;
		
		if(pdMulArray[0] != pdMulArray[1]){
			LibPD.SendFloat("PD_mul", pdMul);
		}
		pdMulArray[1] = pdMulArray[0];
	}

	void WindMul(){
		windMulArray[0] = windMul;

		if(windMulArray[0] != windMulArray[1]){
			LibPD.SendFloat("Wind_mul", windMul);
		}
		windMulArray[1] = windMulArray[0];
	}

	void MusicMul(){
		musicMulArray[0] = musicMul;
		
		if(musicMulArray[0] != musicMulArray[1]){
			LibPD.SendFloat("Music_mul", musicMul);
		}
		musicMulArray[1] = musicMulArray[0];
	}

	void CricketsMul(){
		cricketsMulArray[0] = cricketsMul;
		
		if(cricketsMulArray[0] != cricketsMulArray[1]){
			LibPD.SendFloat("Crickets_mul", cricketsMul);
		}
		cricketsMulArray[1] = cricketsMulArray[0];
	}

	void GlimpsesMul(){
		glimpsesMulArray[0] = glimpsesMul;
		
		if(glimpsesMulArray[0] != glimpsesMulArray[1]){
			LibPD.SendFloat("Glimpses_mul", glimpsesMul);
		}
		glimpsesMulArray[1] = glimpsesMulArray[0];
	}


	void PDToggle(){
		
		pdToggleArray[0] = pdToggle;
		
		if (pdToggleArray[0] != pdToggleArray[1] && pdToggleArray[0] == true){
			LibPD.SendFloat ("PD_toggle", 1.0F);
		} else if (pdToggleArray[0] != pdToggleArray[1] && pdToggleArray[0] == false){
			LibPD.SendFloat ("PD_toggle", 0.0F);
		}
		pdToggleArray[1] = pdToggleArray[0];
		pdToggle = pdToggleArray[0];
	}

	void WindToggle(){
		
		windToggleArray[0] = windToggle;
		
		if (windToggleArray[0] != windToggleArray[1] && windToggleArray[0] == true){
			LibPD.SendFloat ("Wind_toggle", 1.0F);
		} else if (windToggleArray[0] != windToggleArray[1] && windToggleArray[0] == false){
			LibPD.SendFloat ("Wind_toggle", 0.0F);
		}
		windToggleArray[1] = windToggleArray[0];
		windToggle = windToggleArray[0];
	}

	void MusicToggle(){
		
		musicToggleArray[0] = musicToggle;
		
		if (musicToggleArray[0] != musicToggleArray[1] && musicToggleArray[0] == true){
			LibPD.SendFloat ("Music_toggle", 1.0F);
		} else if (musicToggleArray[0] != musicToggleArray[1] && musicToggleArray[0] == false){
			LibPD.SendFloat ("Music_toggle", 0.0F);
		}
		musicToggleArray[1] = musicToggleArray[0];
		musicToggle = musicToggleArray[0];
	}

	public void SetMusicToggle(bool toggle){
		musicToggle = toggle;
	}

	void CricketsToggle(){
		
		cricketsToggleArray[0] = cricketsToggle;
		
		if (cricketsToggleArray[0] != cricketsToggleArray[1] && cricketsToggleArray[0] == true){
			LibPD.SendFloat ("Crickets_toggle", 1.0F);
		} else if (cricketsToggleArray[0] != cricketsToggleArray[1] && cricketsToggleArray[0] == false){
			LibPD.SendFloat ("Crickets_toggle", 0.0F);
		}
		cricketsToggleArray[1] = cricketsToggleArray[0];
		cricketsToggle = cricketsToggleArray[0];
	}

	void GlimpsesToggle(){
		
		glimpsesToggleArray[0] = glimpsesToggle;
		
		if (glimpsesToggleArray[0] != glimpsesToggleArray[1] && glimpsesToggleArray[0] == true){
			LibPD.SendFloat ("Glimpses_toggle", 1.0F);
		} else if (glimpsesToggleArray[0] != glimpsesToggleArray[1] && glimpsesToggleArray[0] == false){
			LibPD.SendFloat ("Glimpses_toggle", 0.0F);
		}
		glimpsesToggleArray[1] = glimpsesToggleArray[0];
		glimpsesToggle = glimpsesToggleArray[0];
	}

	public void Start(){
		LibPD.SendFloat ("Environment", 1.0F); // dit a pd qu'il est ouvert par Unity
	}

	public void Update(){
		WindToggle ();
		MusicToggle ();
		CricketsToggle();
		GlimpsesToggle();
		PDToggle();

		WindRvb ();
		MusicRvb ();
		CricketsRvb ();

		WindMul ();
		MusicMul ();
		CricketsMul();
		GlimpsesMul();
		PDMul();
	}
}