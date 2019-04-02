using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeteors : MonoBehaviour
{
    public GameObject target;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            GetComponent<AudioSource>().Play();
            for (int i = 0; i < 55; i++)
                Invoke("Spawn", i);
        }
    }

    void Spawn()
    {
        float x = Random.Range(-100.0f, 100.0f); //координата спавна
        float y = Random.Range(200.0f, 300.0f); //координата спавна
        float z = Random.Range(-100.0f, 100.0f); //координата спавна
        Instantiate(target, new Vector3(x, y, z), Quaternion.identity); //спавн
    }
}
