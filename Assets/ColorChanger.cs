using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour {

public SpriteRenderer rend;
public Color color;
public float rotationSpeed;
public float moveSpeed;
public TrailRenderer trailRend;

	// Use this for initialization
	void Start ()
	{
	rend.color = color;
	rend.color = new Color(0, 0.23f, 0.33f);
rotationSpeed = 150f;
moveSpeed = 10f;

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(KeyCode.LeftArrow))
		{
	transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
		}
	if (Input.GetKey(KeyCode.RightArrow))
	{
	transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
	}
	if (Input.GetKey(KeyCode.UpArrow))
	{
	transform.Translate(-moveSpeed  * Time.deltaTime, 0, 0, Space.Self);
		rend.color = new Color(0, 1.23f, 0.33f);

	}
	if (Input.GetKey(KeyCode.DownArrow))
	{
transform.Translate(moveSpeed /2  * Time.deltaTime, 0, 0, Space.Self);
rend.color = new Color(1, 0, 0);
trailRend.endColor = Color.red;
trailRend.startColor = Color.green;
	}
		
	}
}
