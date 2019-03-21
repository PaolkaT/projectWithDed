using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class day_tim : MonoBehaviour
{

    public Text Phase_Time;                //таймер до дня/ночи
    float day_time=Sunset.day_time;            //время длительности дня
    float night_time=Sunset.night_time;         //время длительности ночи
    float time_now=0;                         //счётчик текущего времени
    string str_day; //строки для вывода
    string str_night;
    float time_before;//время дл вывода
    
    void Start()
    {
       
    }

   
    void FixedUpdate()
    {
        if (time_before == 0)//сброс счётчика при смене фазы
        {
            time_now = 0f;
        }

        if (Sunset.day)           //время до ночм
        {
            
            time_now += Time.deltaTime;
            time_before = Mathf.CeilToInt(day_time - time_now);
            str_day = time_before.ToString();
            Phase_Time.text = "Время до ночи: " + str_day;
        }
        else
        {                                                        //время до утра
            time_now +=  Time.deltaTime;
            time_before = Mathf.CeilToInt(night_time - time_now);
            str_night = time_before.ToString();
            Phase_Time.text = "Время до утра: " + str_night;
        }
    }
}

