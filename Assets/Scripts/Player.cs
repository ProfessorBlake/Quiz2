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
		
	}
}
