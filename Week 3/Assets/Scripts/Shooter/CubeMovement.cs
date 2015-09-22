using UnityEngine;
using System.Collections;

public class CubeMovement : MonoBehaviour {

	int speed;
		
	float dir = 1;

	void Start () {

		speed = Random.Range (5, 35);
	}
	

	void Update () {
		transform.position = transform.position + Vector3.right * speed * dir * Time.deltaTime;
	
	}

	void OnTriggerEnter (Collider coll) {
		if (coll.gameObject.tag == "Wall") {
		
			dir *= -1;
		}

		if (coll.gameObject.tag == "Player") {

			Application.LoadLevel (Application.loadedLevel);
		}
	}
}
