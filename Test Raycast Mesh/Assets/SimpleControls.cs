/// <summary>
/// 2015-11-12 Benjamin Redahan
/// Simple top down controller to demo line-of-sight procedural mesh
/// </summary>

using UnityEngine;
using System.Collections;

public class SimpleControls : MonoBehaviour {

	public float 	moveSpeed;
	public float 	rotateSpeed;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
		{
			Vector3 temp = transform.position + (transform.forward * Time.deltaTime * moveSpeed);
			transform.position = temp;
		}

		if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
		{
			Vector3 temp = transform.position - (transform.forward * Time.deltaTime * moveSpeed);
			transform.position = temp;
		}

		if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Rotate(0, -2 * rotateSpeed, 0);
		}

		if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
		{
			transform.Rotate(0, 2 * rotateSpeed, 0);
		}
	}
}
