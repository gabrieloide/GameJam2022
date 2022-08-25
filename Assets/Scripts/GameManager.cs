using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    bool GameOver;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Death()
    {
        GameOver = true;
        LevelManager.instance.RespawnPlayer();
        Debug.Log("El juego ha terminado");
    }
}
