using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MetresCount : MonoBehaviour
{
    public Text metres;
    public Vector3 prev;
    public Vector3 inthistime;
    public float rasst;
    public GameObject player;
    void Start()
    {
        prev = player.transform.position;
    }


    void Update()
    {
        inthistime = player.transform.position;
        rasst += Vector3.Magnitude(inthistime - prev);
        metres.text = $"Пройденное расстояние: {Mathf.Ceil(rasst)} м";
        prev = inthistime;
    }
}
