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
    private DateTime time;

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
    }

    private void UpdateTime()
    {
        time = time.AddSeconds(Time.deltaTime * timeMult);
        if(timeGUI != null)
        {
            timeGUI.text = time.ToString("HH:mm");
        }
    }
}
