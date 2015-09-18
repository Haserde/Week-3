using UnityEngine;
using System.Collections;

public class makeaCube : MonoBehaviour {

	public GameObject pillToSpawn;

	void Update () {
			//if i press the G key
			//GetkeyDown or GetKeyUp to fire once upon release of key
		if (Input.GetKey (KeyCode.G)) {
			//spawn cube
			//Instantiate (gameobject, Vector 3 position, Quaternion rotation);
			Instantiate (pillToSpawn, transform.position, transform.rotation);
		}
	}
}
