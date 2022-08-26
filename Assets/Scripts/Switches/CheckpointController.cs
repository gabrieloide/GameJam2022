using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
    public static CheckpointController instance;
    public Checkpoint[] checkpoints;
    public Vector2 spawnPoint;
    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }
    void Start()
    {
        checkpoints = FindObjectsOfType<Checkpoint>();
        spawnPoint = PlayerController.instance.transform.position;
    }
    public void DeactivateCheckpoints()
    {
        for (int i = 0; i < checkpoints.Length; i++)
        {
            checkpoints[i].ResetCheckpoint();
        }
    }
    public void SetSpawnPoint(Vector2 newSpawnPoint)
    {
        spawnPoint = newSpawnPoint;
    }

}
