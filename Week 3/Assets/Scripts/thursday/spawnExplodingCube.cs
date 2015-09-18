using UnityEngine;
using System.Collections;

public class spawnExplodingCube : MonoBehaviour {

	public GameObject expCube;
	private bool canShoot;

	void Start() {
		canShoot = true;
		//InvokeRepeating("shootAuto", .3f, 2.5f); = auto shooting
	}
	
	void spawnACube() {
		Instantiate(expCube, transform.position, transform.rotation);
		canShoot = false;
		Invoke ("turnOnshooter", .5f);
	}

	void turnOnshooter() {
		canShoot = true;
	}
	
	void Update (){
		if (Input.GetKeyDown (KeyCode.A)) {
			if (canShoot == true) {
				spawnACube ();
			}
		}
	}
}
