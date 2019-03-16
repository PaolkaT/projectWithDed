using System;
using System.Collections;
using UnityEngine;

public class _Destroy : MonoBehaviour
{
    public static int count = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Cylinder")
        {
            Destroy(other.gameObject);
            count++;
        }
    }
}