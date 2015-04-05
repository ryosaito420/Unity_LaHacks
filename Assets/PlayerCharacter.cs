using UnityEngine;
using System.Collections;

public class PlayerCharacter : MonoBehaviour {


	float boundX;
	float boundY;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){
		print ("touched goal");

		Vector3 temp = transform.position;
		temp.x += 10.0f;
		temp.z += 10.0f;
		transform.position = temp;

	}
}
