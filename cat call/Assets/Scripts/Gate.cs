using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : ButtonConnection
{
    public Transform openTransform;
    public Transform closedTransform;
    public float speed_toOpen = 1f;
    public float speed_toClose = 1f;


    private void Update()
    {
        if (isAvtivated)
        {
            transform.position = Vector3.MoveTowards(transform.position, openTransform.position, speed_toOpen * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, closedTransform.position, speed_toClose * Time.deltaTime);
        }
        
    }
}
