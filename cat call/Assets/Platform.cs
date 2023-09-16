using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject platform;

    public Transform[] points;
    public float speed;
    public float stayTime;
    public bool isMoving = true;
    float waitStart;
    public int currentPoint;

    // Start is called before the first frame update
    void Start()
    {
        waitStart = Time.timeSinceLevelLoad;    
        isMoving = false;
        platform.transform.position = points[0].position;
        currentPoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
        platform.transform.position = Vector2.MoveTowards(platform.transform.position, points[currentPoint].position, speed * Time.deltaTime);
        if (isMoving)
        {
            
            if ( Vector2.Distance(platform.transform.position, points[currentPoint].position) < 0.1f)
            {
                isMoving = false;
                waitStart = Time.timeSinceLevelLoad;
            }
        }
        else if(waitStart + stayTime < Time.timeSinceLevelLoad)
        {
            isMoving = true;
            if (currentPoint + 1 < points.Length)
            {
                currentPoint++;
            }
            else
            {
                currentPoint = 0;
            }
        }
    }

}
