using UnityEngine;
using System.Collections;

public class SphereControl : MonoBehaviour {

	float ballSize;
	float ballInterval = 1f;

	// Use this for initialization
	void Start () {
		ballSize = GetComponent<SphereCollider>().radius;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("up")) { // enlarge the sphere
			ballSize += ballInterval;
			transform.localScale = new Vector3(ballSize, ballSize, ballSize);
		}
		if (Input.GetKeyDown("down")) { // shrink the sphere
			if (ballSize - ballInterval > 0) {
				ballSize -= ballInterval;
				transform.localScale = new Vector3(ballSize, ballSize, ballSize);
			}
		}
	}
}
