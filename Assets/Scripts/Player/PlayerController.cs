using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    public float speed;
    Rigidbody2D rigidBody2D;
    Animator animator;
    float horizontalMovement;
    float verticalMovement;

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
        rigidBody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        rigidBody2D.velocity = new Vector2(horizontalMovement, verticalMovement).normalized * speed;


        horizontalMovement = Input.GetAxisRaw("Horizontal");
        verticalMovement = Input.GetAxisRaw("Vertical");

        animator.SetBool("RunHorizontal", verticalMovement != 0);
        animator.SetBool("RunVertical", horizontalMovement != 0);
        Flip();
    }
    void Flip()
    {
        if (horizontalMovement > 0.01)
        {
            transform.localScale = Vector2.one;
        }
        else if (horizontalMovement < -0.01)
        {
            transform.localScale = new Vector2(-1, 1);
        }
    }
}
