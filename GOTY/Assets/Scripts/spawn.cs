using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour         //спавн монеток
{
    public GameObject [] prefabs;                     //массив монеток
    public float time = 0.1f;  //услоное время появления
    public float time_now;

    void create()//функция создания красной или жёлтой монетки в случайном положении
    {
        float x = Random.Range(-5f, 5f);
        float z = Random.Range(90f, 110f);
        int chance = Random.Range(1, 100) % 3;//шанс появления красной
        if (chance == 0)
            Instantiate(prefabs[1], new Vector3(x, 101, z), Quaternion.identity);
        else
            Instantiate(prefabs[0], new Vector3(x, 101, z), Quaternion.identity);
    }

    void Start()
    {
        time_now = time;//счётчик времени
    }

    
    void Update()
    {
        if (sunset.day == false)          //появляются только ночью
        {
            time_now -= Time.deltaTime;
            if (time_now <= 0)
            {
                create();
                time_now = time;
            }
        }
        else time_now = time;   //cброс счётчика при наступлении дня
    }
}
