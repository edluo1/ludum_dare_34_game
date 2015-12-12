using UnityEngine;
using System.Collections;

public class SphereControl : MonoBehaviour {

	float ballSize;
	public float ballInterval = 1f;
	float mass;
	public float massInterval = 4f;

	// Use this for initialization
	void Start () {
		ballSize = transform.localScale.x;
		mass = GetComponent<Rigidbody>().mass;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("up")) { // enlarge the sphere
			ballSize += ballInterval;
			mass += massInterval;
			transform.localScale = new Vector3(ballSize, ballSize, ballSize);
			GetComponent<Rigidbody>().mass = mass;
		}
		if (Input.GetKeyDown("down")) { // shrink the sphere
			if (ballSize - ballInterval > 0) {
				ballSize -= ballInterval;
				mass -= massInterval;
				transform.localScale = new Vector3(ballSize, ballSize, ballSize);
				GetComponent<Rigidbody>().mass = mass;
			}
		}
		
	}
}
