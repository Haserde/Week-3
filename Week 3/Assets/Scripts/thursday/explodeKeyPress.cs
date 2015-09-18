using UnityEngine;
using System.Collections;

public class explodeKeyPress : MonoBehaviour {

	public GameObject Explosion;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.T)) {
			Destroy (gameObject);
		}
	}
	
	void OnDestroy() {
		Debug.Log("this is dead!");
			Instantiate( Explosion, transform.position, transform.rotation);
	}
}