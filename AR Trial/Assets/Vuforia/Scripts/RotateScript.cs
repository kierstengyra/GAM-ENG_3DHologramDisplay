using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour {
	private float sensitivity;
	private Vector3 mouseReference;
	private Vector3 mouseOffset;
	private Vector3 rotation;
	private bool isRotating;
	Rigidbody rb;

	void Start () {
		sensitivity = 1f;
		rotation = Vector3.zero;
		rb = GetComponent<Rigidbody> ();
	}

	void Update () {
		if (isRotating) {
			mouseOffset = (Input.mousePosition - mouseReference);

			rotation.z = -(mouseOffset.x + mouseOffset.x) * sensitivity;
			rb.AddTorque (Vector3.up * rotation.z);

			mouseReference = Input.mousePosition;
		}
	}

	void OnMouseDown () {
		isRotating = true;
		mouseReference = Input.mousePosition;
	}

	void OnMouseUp() {
		isRotating = false;
	}
}