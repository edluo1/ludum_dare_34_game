using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public Transform target;
	public float scale;
	public float moveSpeed;
	Camera myCam;

	// Use this for initialization
	void Start () {
		myCam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		myCam.orthographicSize = (Screen.height) / scale;
		
		if (target) {
			transform.position = Vector3.Lerp(transform.position, (target.position+new Vector3(0,0,transform.position.z)), moveSpeed);
		}
		
	}
}
