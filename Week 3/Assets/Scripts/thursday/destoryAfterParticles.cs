using UnityEngine;
using System.Collections;

public class destoryAfterParticles : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, gameObject.GetComponent<ParticleSystem>().duration); 
	}
}
