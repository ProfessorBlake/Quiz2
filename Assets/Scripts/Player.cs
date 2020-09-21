using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public CharacterController CC;
	public Transform CameraTransform;
	public float MoveSpeed;
	public float MouseSensitivity;

	private float xRotation = 0f;

	private void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
	}

	private void Update()
	{
		Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * MoveSpeed * Time.deltaTime;
		CC.Move((moveInput.y * transform.forward) + (moveInput.x * transform.right) + (transform.up * -9.8f * Time.deltaTime));

		Vector2 mouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
		transform.Rotate(Vector3.up * mouseInput.x * MouseSensitivity);
		xRotation -= mouseInput.y * MouseSensitivity;
		xRotation = Mathf.Clamp(xRotation, -90f, 90f);
		CameraTransform.localRotation = Quaternion.Euler(new Vector3(xRotation, 0f, 0f));

		if (Input.GetMouseButtonDown(0))
		{
			RaycastHit hit;
			if(Physics.Raycast(CameraTransform.position, CameraTransform.forward, out hit))
			{
				Target t = hit.transform.GetComponent<Target>();
				if(t)
				{
					t.Hit();
				}
			}
		}
	}
}
