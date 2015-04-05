using UnityEngine;
using System.Collections;

public class WinCondition : MonoBehaviour {

	//public GameObject target;

	// Use this for initialization
	void Start () {
		//Debug.Log (target.name);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
			Debug.Log ("Win");
			//transform.GetComponent<BoxCollider>().enabled = false;
	}
}
