using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LibPDBinding;
using System;

public class SendOSC : MonoBehaviour {

	List<int> pianoNotes = new List<int>();
	List<int> pianoVel = new List<int>();

	void Start() {
		LibPD.Subscribe("music_piano_midi");
		LibPD.List += ReceiveList;
		OSCHandler.Instance.Init();
	}

	void ReceiveList(string send, object[] values){
		if (send == "music_piano_midi") {
			pianoNotes.Add((int)(float)values[0]);
			pianoVel.Add((int)(float)values[1]);
		}
	}

	void OnApplicationQuit() {
		LibPD.List -= ReceiveList;
		LibPD.Unsubscribe("music_piano_midi");
	}

	void Update(){
		//Debug.Log(pianoNotes.Count);
		for(int i = pianoNotes.Count; i > 0; i--){
			OSCHandler.Instance.SendMessageToClient("Pd", "/piano/vel", pianoVel[0]);
			OSCHandler.Instance.SendMessageToClient("Pd", "/piano/note", pianoNotes[0]);
			pianoNotes.RemoveAt(0);
			pianoVel.RemoveAt(0);
		}
	}
}
