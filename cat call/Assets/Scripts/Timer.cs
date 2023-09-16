using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timerTime = 0f;
    public TextMeshProUGUI minutes;
    public TextMeshProUGUI seconds;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // add time to timerTime
        timerTime += Time.deltaTime;
        // convert timerTime to minutes and seconds
        int minutesInt = Mathf.FloorToInt(timerTime / 60f);
        int secondsInt = Mathf.FloorToInt(timerTime - minutesInt * 60);
        // display minutes and seconds
        minutes.text = minutesInt.ToString();
        seconds.text = secondsInt.ToString();
    }
}
