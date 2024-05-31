using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad de movimiento del personaje

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Capturando la entrada del jugador
        movement.x = Input.GetAxisRaw("Horizontal"); // A, D, Izquierda, Derecha
        movement.y = Input.GetAxisRaw("Vertical"); // W, S, Arriba, Abajo
    }

    void FixedUpdate()
    {
        // Moviendo el personaje
        //rb.MovePosition(rb.position + movement * velocidad * Time.fixedDeltaTime);
        rb.velocity=movement*velocidad * Time.fixedDeltaTime;
    }
}
