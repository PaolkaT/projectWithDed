using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhaseTimer : MonoBehaviour                   //скрипт для выводва времени, оставшегося до следующей фа
{

    public Text Phase_Time;                //таймер до дня/ночи
   public  float day_time = Sunset.day_time;            //время длительности дня
   public float night_time = Sunset.night_time;         //время длительности ночи
    public float time_now = 0;                         //счётчик текущего времени
    string str_day; //строки для вывода
    string str_night;
    float time_before;//время дл вывода     
    float time;
     void Start()
    {
        time = night_time + day_time;
    }
    void Update()
    {
        
        if (Sunset.day)           //время до ночм
        {            
            
            time_before = Mathf.CeilToInt(day_time - (Time.time-(Sunset.dayCount*time)));
            str_day = time_before.ToString();
            Phase_Time.text = "Время до ночи: " + str_day;
        }
        else
        {            
            
            time_before = Mathf.CeilToInt(night_time - (Time.time - (Sunset.dayCount * time)-day_time));
            str_night = time_before.ToString();
            Phase_Time.text = "Время до утра: " + str_night;
        }
    }
}

