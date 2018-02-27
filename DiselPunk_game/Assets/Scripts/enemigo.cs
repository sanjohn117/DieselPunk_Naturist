using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour {

	public float velocidadH;
	public float velocidadV;
	public float vida= 0.0f;
	float TimerX = 0.0f;
	float TimerY = 0.0f;

	// Use this for initialization
	void Start () 
	{

		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		transform.position += new Vector3 (Time.deltaTime * velocidadH, 0, 0);
		TimerX += Time.deltaTime;

			if (TimerX > 1.0f) 
			{
				velocidadH *= -1;
				TimerX = 0;
			}
			
	
		transform.position += new Vector3 (0,Time.deltaTime*velocidadV,0);
		TimerY += Time.deltaTime;

			if (TimerY > 1.0f) 
			{
				velocidadV *= -1;
				TimerY = 0;
			}

	}
}