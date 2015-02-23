using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	

		if (transform.position.x <= -33f){
		transform.position += new Vector3 (2.2f, 0f, 0f) * Time.deltaTime;
		}

	}

}
