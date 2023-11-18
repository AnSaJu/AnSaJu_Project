using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed = 500f; // Velocidad del movimiento

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Obtener la entrada del teclado o de otro dispositivo
        float horizontalInput = Input.GetAxis("Horizontal");

        // Aplica el movimiento al Rigidbody2D multiplicado por Time.fixedDeltaTime
        rb.velocity = new Vector2(horizontalInput * speed, 0f) * Time.fixedDeltaTime;
    }
}
