using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLights : MonoBehaviour
{
    bool turnOn = false;
    SpriteRenderer spriteRenderer;
    public Sprite TurnOn, TurnOff;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) && turnOn)
        {
            spriteRenderer.sprite = TurnOn;

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            turnOn = true;      
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            turnOn = false;
            spriteRenderer.color = Color.magenta;
        }
    }
}
