using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCatSound : MonoBehaviour
{
    public AudioClip[] catSounds;



    public float minTime = 5f;
    public float maxTime = 10f;
    float lastTime = 0f;




    // make a random cat sound every 5-10 seconds, play with audio box
    void Update()
    {
        if (Time.time > lastTime + Random.Range(minTime, maxTime))
        {
            lastTime = Time.time;
            AudioBox.instance.PlayClip(catSounds[Random.Range(0, catSounds.Length)]);
        }
    }
}
