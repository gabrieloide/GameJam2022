using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Vector3 start;
    public Vector3[] target;
    public float lerpDuration;
    public int i;
    public Vector3 Position;
    public bool NextPosition;
    private void Start()
    {
        Position = transform.position;
    }
    void Update()
    {
        if (NextPosition)
        {
            i++;
        }
        if (NextPosition)
        {
            NextPosition = false;
            StartCoroutine(LerpPosition(start, target[i], lerpDuration));
        }
    }
    public IEnumerator LerpPosition(Vector3 start, Vector3 target, float lerpDuration)
    {
        float TimeElapsed = 0f;
        while (TimeElapsed < lerpDuration)
        {
            transform.position = Vector3.Lerp(start, target, TimeElapsed / lerpDuration);
            TimeElapsed += Time.deltaTime;
            yield return null;
        }
        transform.position = target;
        newPosition();
    }
    public void newPosition()
    {
        target[i] = start;
        start = transform.position;
    }
}
