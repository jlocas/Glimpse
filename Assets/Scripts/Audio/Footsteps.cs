using UnityEngine;
using System.Collections;

public class Footsteps : MonoBehaviour {
	
	public PlayerMove playerMove;
	public FloorTexture floor;
	AudioClips clips;
	AudioPlayer audioPlayer;


	public GameObject player;



	string lastState;


	void PlayLandings()
	{
		if (lastState == "Jump" && playerMove.hasLanded == true)
		{
			string surface = floor.ReadTexture(player.transform);

			switch(surface)
			{
			case "Dirt":
				audioPlayer.Play(clips.DirtLand(), player, 2);
				break;
			case "Grass":
				audioPlayer.Play(clips.GrassLand(), player, 2);
				break;
			case "Stone":
				audioPlayer.Play(clips.StoneLand(), player, 2, Random.Range(1.5f, 1.6f));
				break;
			}
			lastState = "Land";
		}
	}

	public void PlayFootsteps(string state)
	{
		string surface = floor.ReadTexture(player.transform);

		if (playerMove.grounded == true)
		{
			switch(state)
			{
			case "Walk":
				switch(surface)
				{
				case "Dirt":
					audioPlayer.Play(clips.DirtWalk(), player, 2);
					break;
				case "Grass":
					audioPlayer.Play(clips.GrassWalk(), player, 2);
					break;
				case "Stone":
					audioPlayer.Play(clips.StoneWalk(), player, 2, Random.Range(1.5f, 1.6f));
					break;
				case "Water":
					audioPlayer.Play(clips.WaterWalk(), player, 2);
					break;
				}
				lastState = "Walk";
				break;
				
			case "Run":
				switch(surface)
				{
				case "Dirt":
					audioPlayer.Play(clips.DirtRun(), player, 2);
					break;
				case "Grass":
					audioPlayer.Play(clips.GrassRun(), player, 2);
					break;
				case "Stone":
					audioPlayer.Play(clips.StoneRun(), player, 2, Random.Range(1.5f, 1.6f));
					break;
				case "Water":
					audioPlayer.Play(clips.WaterWalk(), player, 2, 0.0F, (Random.Range(0.9f, 1.0f) - 0.5f));
					break;
				}
				lastState = "Run";
				break;
				
			case "Jump":
				switch(surface)
				{
				case "Dirt":
					audioPlayer.Play(clips.DirtJump(), player, 2);
					break;
				case "Grass":
					audioPlayer.Play(clips.GrassJump(), player, 2);
					break;
				case "Stone":
					audioPlayer.Play(clips.StoneJump(), player, 2, Random.Range(1.5f, 1.6f));
					break;
				}
				lastState = "Jump";
				break;
			}
		}
	}

	public string ReadTexture()
	{
		return floor.ReadTexture(player.transform);
	}

	void Start(){
		//audioPlayer = audioPlayer.Find();
		clips = GameObject.Find("Sound").GetComponent<AudioClips>();
		audioPlayer = GameObject.Find("Sound").GetComponent<AudioPlayer>();
		player = GameObject.Find("Player/Player Model/Glimpse_Body");
	}

	void Update(){
		PlayLandings();
	}

	

}

