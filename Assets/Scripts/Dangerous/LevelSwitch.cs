using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSwitch : MonoBehaviour
{
    bool turnOn = false;
    public GameObject objectToSwitch;

    SpriteRenderer spriteRenderer;
    public bool deactivateToSwitch;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) && turnOn)
        {
            spriteRenderer.color = Color.red;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !turnOn)
        {

        }
    }
}
