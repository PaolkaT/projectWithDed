using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryCube_test : MonoBehaviour
{
    public float distantion;
    private float nextActionTime = 0.5f;
    public GameObject color;
    public float floatrange = 50.0f;
    public float timeToNextStep = 0.005f;

    void Start()
    {
        color = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {

        if ((Time.time > nextActionTime) && (Vector3.Distance(color.transform.position, transform.position) > floatrange))
        {
            float rx = Random.Range(-4f, 4f);
            float rz = Random.Range(-4f, 4f);
            transform.Translate(new Vector3(rx, 0, rz) * Time.deltaTime * 5);
            nextActionTime += timeToNextStep;
        }
        else
            transform.position = Vector3.MoveTowards(transform.position, color.transform.position, Time.deltaTime);
    }
}