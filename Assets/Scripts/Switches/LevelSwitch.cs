using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSwitch : MonoBehaviour
{
    public bool turnOn = false;
    public GameObject objectToSwitch;

    SpriteRenderer spriteRenderer;
    public Sprite LeverOn, LeverOff;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) && turnOn)
        {
            spriteRenderer.sprite = LeverOn;
            objectToSwitch.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            turnOn = true;
        }
    }
}
