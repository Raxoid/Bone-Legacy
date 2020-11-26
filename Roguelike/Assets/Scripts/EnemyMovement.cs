using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    public Animator animator;

    private float distance;

    private Vector2 PlayerDirection;

    public SpriteRenderer spriteRenderer;

    public Transform Player;

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Move();
        Flip();
        animator.SetFloat("Distance", 1);
    }

    void Move()
    {
        Vector3 direction = Player.position - this.transform.position;

        direction.Normalize();

        PlayerDirection = direction;

        rb.MovePosition((Vector2)this.transform.position + (PlayerDirection * moveSpeed * Time.deltaTime));
    }

    void Flip()
    {
        if (Player.position.x > this.transform.position.x)
        {
            spriteRenderer.flipX = true;
        }
        else if (Player.position.x < this.transform.position.x)
        {
            spriteRenderer.flipX = false;
        }
    }
}
