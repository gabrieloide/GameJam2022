using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidadMovimiento;
    Vector2 puntoMovimiento;
    public Vector2 offsetPuntoMovimiento;
    public LayerMask obstaculos;
    public float radioCirculo;
    bool moviendo = false;
    Vector2 input;



    private void Start()
    {
        puntoMovimiento = transform.position;
    }
    private void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");


        if (moviendo)
        {
            transform.position = Vector2.MoveTowards(transform.position, puntoMovimiento, velocidadMovimiento * Time.deltaTime);
            if (Vector2.Distance(transform.position, puntoMovimiento)==0)
            {
                moviendo = false;
            }
        }
        if ((input.x !=0 ^ input.y != 0) && !moviendo)
        {
            Vector2 puntoEvaluar = new Vector2(transform.position.x, transform.position.y) + offsetPuntoMovimiento + input;
            if (!Physics2D.OverlapCircle(puntoEvaluar, radioCirculo, obstaculos))
            {
                moviendo = true;
                puntoMovimiento += input;
            }
        }

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(puntoMovimiento + offsetPuntoMovimiento, radioCirculo);
    }
}
