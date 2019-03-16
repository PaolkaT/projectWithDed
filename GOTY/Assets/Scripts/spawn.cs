using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject [] prefabs;
    public float time = 0.1f;
    public float time_now;

    void create()
    {
        float x = Random.Range(-5f, 5f);
        float z = Random.Range(90f, 110f);
        int chance = Random.Range(1, 100) % 3;
        if (chance == 0)
            Instantiate(prefabs[1], new Vector3(x, 101, z), Quaternion.identity);
        else
            Instantiate(prefabs[0], new Vector3(x, 101, z), Quaternion.identity);
    }

    void Start()
    {
        time_now = time;
    }

    
    void Update()
    {
        if (sunset.day == false)
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
