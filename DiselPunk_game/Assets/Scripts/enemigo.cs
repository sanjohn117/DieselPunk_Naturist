using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour {

	public float speed = 5;
	public int vida = 100;
	public float timer = 0;
	public int daño = 10;
	bool enContacto = false;
    

	// Use this for initialization
	void Start () {

	}

    // Update is called once per frame
    void Update() {
        print(timer);
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

        if (enContacto == true)
            timer += Time.deltaTime;

        if (timer >= 1)
        {
            timer = 0;
            vida -= daño;
        }
        if (vida <= 0)
        {
            
        }
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject colisionado = collision.gameObject;
       // print(colisionado.transform.tag);
        if (colisionado.transform.tag == "Muro")
            speed *= -1;

        if (colisionado.transform.tag == "Player")
            speed *= -1;

        if (colisionado.transform.tag == "Enemigo")
            enContacto = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        GameObject colisionado = collision.gameObject;
        if (colisionado.transform.tag == "Enemigo")
            enContacto = false;
    }
}
