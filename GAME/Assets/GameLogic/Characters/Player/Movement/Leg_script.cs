using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leg_script : MonoBehaviour
{
    public float rot_speed = 10f;
    void Start()
    {
        Vector3 rotationVector = new Vector3(0, 0, 0);
        Quaternion rotation = Quaternion.Euler(rotationVector);
        
    }

    void Update()
    {
        float z = 0;
        z += Input.GetAxis("Vertical");    
        transform.rotation = Quaternion.Euler(z * Mathf.Sin(Time.time * 8) * rot_speed, 0, 0);
    }
}