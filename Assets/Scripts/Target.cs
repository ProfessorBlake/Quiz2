using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
	private Vector3 moveTarget;
	private Vector3 position;
	private Vector3 velocity;

	private void Start()
	{
		Hit();
	}

	private void Update()
	{
		transform.Rotate(new Vector3(10f, 20f, 30f) * Time.deltaTime);
		transform.position = Vector3.SmoothDamp(transform.position, moveTarget, ref velocity, 0.25f);
	}

	public void Hit()
	{
		position = transform.position;
		moveTarget = new Vector3(Random.Range(-10f, 10f), Random.Range(2.5f,6f), Random.Range(-12f, 21f));
	}
}
