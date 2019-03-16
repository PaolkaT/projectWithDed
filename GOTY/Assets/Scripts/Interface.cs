using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Interface : MonoBehaviour
{
    public Text cntCyl;
    public Text metres;
    public GameObject player;
    public GameObject hat;
    public GameObject buyhatt;
    public Button buyhat;
    public Vector3 prev;
    public Vector3 inthistime;
    public float rasst;
    void Start()
    {
        prev = player.transform.position;
        buyhatt.SetActive(false);
    }
    void Update()
    {
        inthistime = player.transform.position;
        rasst += Vector3.Magnitude(inthistime - prev);
        metres.text = $"Пройденное расстояние: {Mathf.Ceil(rasst)} м";
        prev = inthistime;

        cntCyl.text = $"Количество собранных жёлтых монет: {_Destroy.count_yellow}";

        if (sunset.day==false)
            buyhatt.SetActive(true);
        buyhat.onClick.AddListener(ButtonClick);
        if (sunset.day)
            buyhatt.SetActive(false);
    }
    void ButtonClick()
    {
        if (_Destroy.count_yellow >= 5)
        {
            buyhatt.SetActive(true);
            _Destroy.count_yellow -= 5;
            hat.SetActive(true);
        }
    }
}