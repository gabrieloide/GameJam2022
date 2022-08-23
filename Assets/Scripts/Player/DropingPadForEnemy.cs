using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropingPadForEnemy : MonoBehaviour
{
    public Transform points;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(points);
        }
    }
}
