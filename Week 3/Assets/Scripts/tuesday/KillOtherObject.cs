using UnityEngine;
using System.Collections;

public class KillOtherObject : MonoBehaviour {

	void OnTriggerExit( Collider otherObject ) {
		//Destroy (otherObject.gameObject.GetComponent<Rigidbody>());
		//without rigidbody it stops
		if (otherObject.gameObject.tag == "Cubes") {
			Destroy (otherObject.gameObject);
		}
	}
}