using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float bounceForce = 10f; // Fuerza de rebote del trampolín

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Obtener el Rigidbody2D del jugador
            Rigidbody2D playerRb = other.GetComponent<Rigidbody2D>();

            // Verificar que el Rigidbody2D existe
            if (playerRb != null)
            {
                // Aplicar fuerza de rebote al jugador
                playerRb.velocity = new Vector2(playerRb.velocity.x, bounceForce);

                // Activar animación del trampolín si hay un Animator
                Animator animator = GetComponent<Animator>();
                if (animator != null)
                {
                    animator.SetTrigger("Bounce");
                }
            }
        }
    }
}
