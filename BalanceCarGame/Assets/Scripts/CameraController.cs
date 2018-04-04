using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform target;


	void FixedUpdate()
	{
		//setting the position the same as the car 
		//there will still be a problem with the z axis
		//transform.position = target.position;

		Vector3 newPosition = target.position;
		//pulled the camera back so to see everything
		newPosition.z = -10;

		transform.position = newPosition;
	}

}
