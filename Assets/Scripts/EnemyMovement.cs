using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float movementSpeed;
    public int startPos;
    public List<Transform> Points;

    int i;

    private void Start()
    {
        transform.position = Points[startPos].position;
    }
    private void Update()
    {
        if (Vector2.Distance(transform.position, Points[i].position) < 0.02f)
        {
            i++;
            if (i == Points.Count)
            {
                i = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, Points[i].position, movementSpeed * Time.deltaTime);
    }
}
