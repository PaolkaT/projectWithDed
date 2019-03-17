using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Interface : MonoBehaviour    //Скрипт для вывода интерфейса на экран игрока
{
  
    Player igrok;
    public Text cntCyl;
    public Text metres;
    public GameObject player;
    public GameObject hat;
    public GameObject buyhatt;         //Паша потом закомментит
    public Button buyhat;
    public Vector3 prev;
    public Vector3 inthistime;
    public float rasst;
    void Start()
    {
        igrok = player.GetComponent<Player>();
        prev = igrok.transform.position;
        buyhatt.SetActive(false);
    }
    void Update()
    {

        inthistime = player.transform.position;
        rasst += Vector3.Magnitude(inthistime - prev);
        metres.text = $"Пройденное расстояние: {Mathf.Ceil(rasst)} м";
        prev = inthistime;

        cntCyl.text = $"Количество собранных  монет: {igrok.CountCoin}";

        if (Sunset.day == false)
            buyhatt.SetActive(true);
        buyhat.onClick.AddListener(ButtonClick);
        if (Sunset.day)
            buyhatt.SetActive(false);
    }
    void ButtonClick()
    {
        if (igrok.CountCoin >= 5)
        {
            buyhatt.SetActive(true);
            igrok.CountCoin -= 5;
            hat.SetActive(true);
        }
    }
}