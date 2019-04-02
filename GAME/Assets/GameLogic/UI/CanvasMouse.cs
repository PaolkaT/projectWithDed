using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CanvasMouse : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public PlayerStats player;
    public GameObject hattext;
    public Text hattexttext;
    public Transform panel;
    GameObject appearingObject;
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!Sunset.day)
        {
            if (gameObject.name == "RawImage") //вот эту строчку нужно изменить при склеивании
                hattexttext.text = ("Шляпа за 5 монет!");
            if (gameObject.name == "RawImage (1)") //эту тоже
                hattexttext.text = ("Ультракрутая и модная шляпа за 10 монет!");
            hattext.SetActive(true);
        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        hattext.SetActive(false);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (!Sunset.day)
        {
            if (gameObject.name == "RawImage" && player.CountCoin >= 5) //и эту
            {
                player.CountCoin -= 5;
                appearingObject = player.transform.Find("hat").gameObject;
                appearingObject.SetActive(true);
            }
            if (gameObject.name == "RawImage (1)" && player.CountCoin >= 10) //и даже эту
            {
                player.CountCoin -= 10;
                appearingObject = player.transform.Find("whitehat").gameObject;
                appearingObject.SetActive(true);
            }
        }
    }
    void Update()
    {
        if (!Sunset.day)
            panel.position = Input.mousePosition + new Vector3(15, 15);
    }
}