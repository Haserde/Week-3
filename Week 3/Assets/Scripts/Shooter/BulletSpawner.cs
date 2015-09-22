using UnityEngine;
using System.Collections;

public class BulletSpawner : MonoBehaviour {

	public GameObject bullet;
	private bool canShoot;

	void Start () {
		canShoot = true;
	}

	void spawnBullet(){
		Instantiate (bullet, transform.position, transform.rotation);
		//canShoot = false;
	}
	
	void Update(){
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			if (canShoot == true) {
				spawnBullet ();
			}
		}
	}
}
