using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

	
	public float speed = 20f;
	
	void Update () {
		//move up through scene
		//transform.position = transform.position + a little up
		transform.position = transform.position + Vector3.forward * speed * Time.deltaTime;
		//move up at 											unit[s] per second 
	}
}
