using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTrap : MonoBehaviour
{
    public GameObject FireActivated;
    public float TimeActivated;
    public float TimeDeactivated;

    private void Start()
    {
        StartCoroutine(FireTrapSequence());
    }
    private void Update()
    {
        
    }
    IEnumerator FireTrapSequence()
    {
        while (true)
        {
            FireActivated.SetActive(false);
            yield return new WaitForSeconds(TimeDeactivated);
            FireActivated.SetActive(true);
            AudioManager.instance.PlaySoundFire();
            yield return new WaitForSeconds(TimeDeactivated);
        }
    }
}
