using UnityEngine;
using System.Collections;

public class WallMovement2 : MonoBehaviour {

	public float speed = 2;
	
	
	void Update() {
		transform.position = transform.position + Vector3.right * speed * Time.deltaTime;
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			Application.LoadLevel (Application.loadedLevel);
		}
	}
}