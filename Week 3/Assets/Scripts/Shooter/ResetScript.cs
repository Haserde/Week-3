using UnityEngine;
using System.Collections;

public class ResetScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {

			Application.LoadLevel (Application.loadedLevel);
		}
	}
}
