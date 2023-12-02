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

    // Start is called before the first frame update
    void Start()
    {
        //fix this a little bit more
        time = DateTime.Now.Date + TimeSpan.FromHours(startTime);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTime();
        UpdateWheel();
        //Invoke("UpdateDay", 1);
    }

    private void UpdateTime()
    {
        time = time.AddSeconds(Time.deltaTime * timeMult);
        if(timeGUI != null)
        {
            timeGUI.text = time.ToString("HH:mm");
        }
    }

    private void UpdateWheel()
    {
        wheel.transform.Rotate(0f, 0f, 1f * Time.deltaTime, Space.Self);
    }

    private void UpdateDay()
    {
        dayGUI.text = "Day " + startDay++;
        /*Debug.Log("Hello!");
        if (timeGUI.text == "00:00")
        {
            dayGUI.text = "Day " + startDay++;
        }*/
    }
}
