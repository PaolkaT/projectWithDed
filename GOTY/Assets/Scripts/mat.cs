using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mat : MonoBehaviour         //вращение монеток
{
    Quaternion originRotation;
    float angle=0f;
    void Start()
    {
        originRotation = transform.rotation;
    }

    
    void FixedUpdate()
    {
        angle ++;
        Quaternion rotationY = Quaternion.AngleAxis(angle, Vector3.up);
        Quaternion rotationX = Quaternion.AngleAxis(angle*2, Vector3.right);
        transform.rotation= originRotation * rotationY *   rotationX;   
    }
}
