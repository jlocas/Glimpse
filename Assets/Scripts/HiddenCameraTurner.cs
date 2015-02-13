using UnityEngine;
using System.Collections;

public class HiddenCameraTurner : MonoBehaviour {
	
	public Camera viewCamera;
	public Transform playerLocation;
	public UnseenActionsTrigger unseenActionsTrigger;
	private bool isCurrentlySeen = true;

	float distance;
	GameObject player;

	// Update is called once per frame
	void Update () {
		Vector3 cameraPosition = viewCamera.WorldToViewportPoint (transform.position);
		if (!(cameraPosition.x > -0.5 && cameraPosition.x < 1.5 && cameraPosition.z > -5)) {
			transform.LookAt (playerLocation.position);

			if (isCurrentlySeen) {
				unseenActionsTrigger.PlayUnseenSound ();
				unseenActionsTrigger.DollParticles(30.0F);
				isCurrentlySeen = false;
			}

		}
		else {
			isCurrentlySeen = true;
			unseenActionsTrigger.DollParticles(0.0F);

		}
	}

	void Start(){
		player = GameObject.Find("Player");
	}
}



