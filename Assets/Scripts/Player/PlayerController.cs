using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    Rigidbody2D rigidBody2D;
    float horizontalMovement;
    float verticalMovement;

    private void Awake()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        rigidBody2D.velocity = new Vector2(horizontalMovement, verticalMovement).normalized * speed;


        horizontalMovement = Input.GetAxisRaw("Horizontal");
        verticalMovement = Input.GetAxisRaw("Vertical");
    }

}
