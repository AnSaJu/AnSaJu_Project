using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borde : MonoBehaviour
{
    [SerializeField]
    float speedIncrease = 1f;

    [SerializeField]
    float directionX = 1f;
    [SerializeField]
    float directionY = 1f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica si la colisión ocurrió con la pelota
        if (collision.gameObject.CompareTag("Ball"))
        {
            Ball ballScript = collision.gameObject.GetComponent<Ball>();
            ballScript.speed += 0.5f;

            // Aplica la nueva dirección a la pelota
            Vector2 newDirection = new Vector2(directionX, directionY).normalized;
            collision.rigidbody.velocity = speedIncrease * collision.rigidbody.velocity.magnitude * newDirection;
        }
    }
}
