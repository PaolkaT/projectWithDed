using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunset : MonoBehaviour
{ 
    public float lenght=1400f*1400f*3.14f/2f;
    static public float day_time = 15f;
    static public float night_time = 15f;
    public float rot = 0f;
    float z;
    public float sun_speed;
    public static bool day=true;
    void Start()
    {              
        sun_speed = lenght / day_time;
    }
    void FixedUpdate()
    {
        if (rot >= 360)
            rot -= 360;

        if (rot<180)
        {
            day = true;
          
            sun_speed = lenght / day_time;
        }

        if (rot>180)
        {
            day = false;            
            sun_speed = lenght / night_time;

        }

        z = sun_speed*Time.deltaTime*Time.deltaTime*Time.deltaTime*Time.deltaTime*7.31f;
        transform.Rotate(Vector3.right, z);
        rot += z;
     
    }
}


