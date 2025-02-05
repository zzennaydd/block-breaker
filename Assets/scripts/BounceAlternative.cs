using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public float bounceForce = 8f; 

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("paddle"))
        {
            // Yukarý doðru zýplama kuvveti uygula
            rb.velocity = new Vector2(rb.velocity.x, bounceForce);
        }
    }
}

