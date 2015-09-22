using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public Vector3 cameraFollowOffset = new Vector3(0,5,-5);
	public Camera followCamera;
	void Start()
	{
		if (followCamera == null)
			followCamera = Camera.main;
	}
	void Update()
	{
		followCamera.transform.position = transform.position + cameraFollowOffset;
	}
}