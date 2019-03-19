using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject target;

    void Start()
    {
        InvokeRepeating("Spawn", 2, 1);
    }
    
    void Spawn()
    {
        float x = Random.Range(-5.0f, 5.0f); //координата спавна
        float y = Random.Range(0f, 5.0f); //координата спавна
        float z = Random.Range(-5.0f, 5.0f); //координата спавна
        Instantiate(target, new Vector3(x, y, z), Quaternion.identity); //спавн
    }
}
