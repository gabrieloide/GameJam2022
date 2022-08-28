using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditExit : MonoBehaviour
{

    private void Start()
    {
        StartCoroutine(ExitCredits());
    }

    IEnumerator ExitCredits()
    {
        yield return new WaitForSeconds(14);
        LevelLoader.instance.load0();
    }
}
