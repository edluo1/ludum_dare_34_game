using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOver : MonoBehaviour {

	private Text levelStatus;
	
	void Start() {
		levelStatus = (Text) GameObject.Find("Level Status").GetComponent<Text>();
	}

	void OnTriggerExit(Collider player) {
		if (player.gameObject.tag == "Player") {
			levelStatus.text ="<color=red>Game Over!</color>";
			Debug.Log("Game over!!");
		}
	}
}
