using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropingPadForEnemy : MonoBehaviour
{
    public Transform points;
    public Vector3 Player;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(points);
        }
    }
}
