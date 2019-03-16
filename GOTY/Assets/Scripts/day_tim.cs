using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class day_tim : MonoBehaviour
{

    public Text Phase_Time;
    float day_time=sunset.day_time;
    float night_time=sunset.night_time;
    float time_now=0;
    string str_day;
    string str_night;
    float time_before;
    
    void Start()
    {
       
    }

   
    void FixedUpdate()
    {
        if (time_before == 0)
        {
            time_now = 0f;
        }

        if (sunset.day)
        {
            
            time_now += Time.deltaTime;
            time_before = Mathf.CeilToInt(day_time - time_now);
            str_day = time_before.ToString();
            Phase_Time.text = "Время до ночи: " + str_day;
        }
        else
        {
            time_now +=  Time.deltaTime;
            time_before = Mathf.CeilToInt(night_time - time_now);
            str_night = time_before.ToString();
            Phase_Time.text = "Время до утра: " + str_night;
        }
    }
}

