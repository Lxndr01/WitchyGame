using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    public Animator animator;

    Vector2 movement;



    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        Vector2 horizontalmove = transform.right * movement.x;
        Vector2 verticalmove = transform.up * movement.y;
        Vector2 velocity = (horizontalmove + verticalmove).normalized * moveSpeed;

        //animation


        if (movement != Vector2.zero)
        {
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
        }


        animator.SetFloat("Speed", movement.sqrMagnitude);

        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }

    /*void FixedUpdate()
    {
        rb.MovePosition(rb.position + velocity *Time.fixedDeltaTime);
    }*/

}
