using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D rigidBody2D;
    public Transform target;
    public float speed;
    private void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rigidBody2D.velocity = (target.position - transform.position).normalized * speed;
    }

}

