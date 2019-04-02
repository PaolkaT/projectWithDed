using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZaebisCamera : MonoBehaviour
{
    
    void Update()
    {
        var dx = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up, dx, Space.World);
    }
}