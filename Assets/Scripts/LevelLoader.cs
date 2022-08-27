using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class LevelLoader : MonoBehaviour
{
    public static LevelLoader instance;
    public Animator transition;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    public void load0()
    {
        Time.timeScale = 1;
        StartCoroutine(LoadLevel(0));
    }
    public void load1()
    {
        StartCoroutine(LoadLevel(1));
    }

    public void load2()
    {
        StartCoroutine(LoadLevel(2));
    }
    public void load3()
    {
        StartCoroutine(LoadLevel(3));
    }
    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(levelIndex);
    }


}
