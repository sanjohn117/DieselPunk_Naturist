using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guardia : MonoBehaviour {

	public float velocidadX;
	public float velocidadY;
	float TimerX = 0.0f;
	float TimerY = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position += new Vector3 (Time.deltaTime * velocidadX, 0, 0);
		TimerX += Time.deltaTime;

			if (TimerX > 2) 
			{
				velocidadX *= -1;
				TimerX = 0;
			}

		transform.position += new Vector3 (0, Time.deltaTime * velocidadY, 0);
		TimerY += Time.deltaTime;

			if (TimerY > 2) 
			{
				velocidadY *= -1;
				TimerY = 0;
			}
	}
}
