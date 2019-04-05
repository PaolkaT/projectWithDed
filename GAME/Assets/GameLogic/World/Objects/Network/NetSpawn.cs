using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetSpawn : NetworkBehaviour         //спавн монеток
{
    public GameObject[] prefabs;                     //массив монеток
    public float time = 1f;  //условное время появления
    public float time_now;

    void create()//функция создания красной или жёлтой монетки в случайном положении
    {
        if (!isServer) return;
        float x = Random.Range(-5f, 5f);
        float z = Random.Range(-5f, 5f);
        int chance = Random.Range(1, 100) % 3;//шанс появления красной
        if (chance == 0)
            Instantiate(prefabs[1], new Vector3(x, 1, z), Quaternion.identity);
        else
            Instantiate(prefabs[0], new Vector3(x, 1, z), Quaternion.identity);

        Instantiate(prefabs[2], new Vector3(Random.Range(-20f, 20f), 1, -Random.Range(20f, 20f)), Quaternion.identity);


    }

    void Start()
    {
        time_now = time;
    }

    void Update()
    {
        if (Sunset.day == false)          //появляются только ночью
        {
            time_now -= Time.deltaTime;
            if (time_now <= 0)
            {
                create();
                time_now = time;
            }
        }
        else time_now = time;

    }
}
