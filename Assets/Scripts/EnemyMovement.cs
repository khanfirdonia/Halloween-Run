using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;
    public float moveDistance = 3f;
    private Vector3 startPos;
    private bool movingRight = true;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (movingRight)
        {
            transform.position += Vector3.right 
                                * speed 
                                * Time.deltaTime;

            if (transform.position.x > 
                startPos.x + moveDistance)
                movingRight = false;
        }
        else
        {
            transform.position += Vector3.left 
                                * speed 
                                * Time.deltaTime;

            if (transform.position.x < 
                startPos.x - moveDistance)
                movingRight = true;
        }
    }
}