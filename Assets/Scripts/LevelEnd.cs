using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelEnd : MonoBehaviour {

	private Text levelStatus;
	
	void Start() {
		levelStatus = (Text) GameObject.Find("Level Status").GetComponent<Text>();
	}
	
	void OnTriggerEnter(Collider player) {
		if (player.gameObject.tag == "Player") {
			levelStatus.text ="Level Complete!";
			Debug.Log("Level complete!");
		}
	}
}
