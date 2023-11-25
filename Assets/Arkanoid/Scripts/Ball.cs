using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    public float speed = 5f; // Velocidad inicial de la pelota

    public TextMeshProUGUI textVelocidad;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Inicializa la velocidad de la pelota
        rb.velocity = new Vector2(Random.Range(1f, 1f), -1f).normalized * speed;
    }

    private void FixedUpdate()
    {
        textVelocidad.text = "" + rb.velocity.magnitude;
        if(rb.velocity.magnitude != speed)
        {
            rb.velocity = rb.velocity.normalized * speed;
        }
    }






}
