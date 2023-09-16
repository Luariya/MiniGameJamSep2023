using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timerTime = 0f;

    public TextMeshProUGUI seconds;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerTime += Time.deltaTime;
        seconds.text = timerTime.ToString("F2");

        
    }
}
