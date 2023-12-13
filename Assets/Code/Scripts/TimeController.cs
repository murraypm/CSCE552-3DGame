using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeController : MonoBehaviour
{
    [SerializeField]
    private float timeMult;

    [SerializeField]
    private float startTime;

    [SerializeField]
    private TextMeshProUGUI timeGUI;

    //https://www.c-sharpcorner.com/article/datetime-in-c-sharp/
    public DateTime time;

    [SerializeField]
    private Transform wheel;

    [SerializeField]
    private TextMeshProUGUI dayGUI;
    private int startDay = 0;

    private string prevTime;
    private string currTime;

    // Start is called before the first frame update
    void Start()
    {
        //fix this a little bit more
        prevTime = "00:00";
        time = DateTime.Now.Date + TimeSpan.FromHours(startTime);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTime();
        UpdateWheel();
    }

    private void UpdateTime()
    {
        time = time.AddSeconds(Time.deltaTime * timeMult);
        if(timeGUI != null)
        {
            currTime = time.ToString("HH:mm");
            timeGUI.text = currTime;
        }
        if(prevTime != currTime)
        {
            prevTime = currTime;
            if(currTime == "19:00")
            {
                //spawn wave
                //spawn resources
            }
            if(currTime == "00:00")
            {
                startDay++;
                dayGUI.text = "Day " + startDay.ToString();
                if(startDay == 5)
                {
                    //win screen
                    //victory sound
                }
            }
        }
    }

    private void UpdateWheel()
    {
        wheel.transform.Rotate(0f, 0f, 1f * Time.deltaTime, Space.Self);
    }
}
