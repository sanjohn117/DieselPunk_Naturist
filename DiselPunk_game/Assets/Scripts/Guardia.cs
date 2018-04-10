using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guardia : MonoBehaviour {

    public float visionRadio;
    public float RangoAtaque;
    public float speed;

    GameObject jugador;
    Vector3 posicionInicial;
    Rigidbody2D rb2d;

    private void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");

        posicionInicial = transform.position;

        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector3 target = posicionInicial;

        RaycastHit2D hit = Physics2D.Raycast(
            transform.position,
            jugador.transform.position - transform.position,
            visionRadio,
            1<< LayerMask.NameToLayer("Default")
            );

        Vector3 forward = transform.TransformDirection(jugador.transform.position - transform.position);
        Debug.DrawRay(transform.position, forward, Color.red);

        if (hit.collider != null) {
            if (hit.collider.tag == "Player") {
                target = jugador.transform.position;
            }
        }

        float distancia = Vector3.Distance(target, transform.position);
        Vector3 direccion = (target - transform.position).normalized;

        if (target != posicionInicial && distancia < RangoAtaque)
        {}
      
        else
        {
            rb2d.MovePosition(transform.position + direccion * speed * Time.deltaTime);
        }
        if (target == posicionInicial && distancia < 0.05f)
        {
            transform.position = posicionInicial;
        }
            Debug.DrawLine(transform.position, target, Color.green);
    }

    void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, RangoAtaque);
        Gizmos.DrawWireSphere(transform.position, visionRadio);

    }
}
