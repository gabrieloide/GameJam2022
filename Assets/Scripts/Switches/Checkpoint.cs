using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public Sprite cpOn, cpOff;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {  
            CheckpointController.instance.DeactivateCheckpoints();
            FindObjectOfType<CameraController>().NextPosition = true;
            spriteRenderer.sprite = cpOn;
            AudioManager.instance.PlaySoundCheckpoint();
            CheckpointController.instance.SetSpawnPoint(transform.position);
        }
    }
    public void ResetCheckpoint()
    {
        spriteRenderer.sprite = cpOff;
    }
}
