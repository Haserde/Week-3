using UnityEngine;
using System.Collections;

public class BulletKill : MonoBehaviour {
		
	public GameObject explosion;

	void start() {
		Destroy (gameObject, gameObject.GetComponent<ParticleSystem> ().duration);
	}

	void OnTriggerEnter(Collider otherObject) {
		if (otherObject.gameObject.tag == "Bullet") {
			Destroy (otherObject.gameObject);
			Destroy (gameObject);
			Instantiate (explosion, transform.position, transform.rotation);
		}
	}
}