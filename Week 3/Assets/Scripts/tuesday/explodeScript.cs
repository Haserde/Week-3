using UnityEngine;
using System.Collections;

public class explodeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//insideUnitSphere calls for random units below one
		GetComponent<Rigidbody> ().AddForce (Random.insideUnitSphere * 1000);
	
	}

}
