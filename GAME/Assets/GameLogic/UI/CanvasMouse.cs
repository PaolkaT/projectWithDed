using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CanvasMouse : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public PlayerStats player;
    public GameObject appearingObject;
    public GameObject hattext;
    public Text hattexttext;
    public Transform panel;
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!Sunset.day)
        {
            if (appearingObject.name == "hat")
                hattexttext.text = ("Шляпа за 5 монет!");
            if (appearingObject.name == "whitehat")
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
            if (appearingObject.name == "hat" && player.CountCoin >= 5)
            {
                player.CountCoin -= 5;
                appearingObject.SetActive(true);
            }
            if (appearingObject.name == "whitehat" && player.CountCoin >= 10)
            {
                player.CountCoin -= 10;
                appearingObject.SetActive(true);
            }
        }
    }
    void Update()
    {
        if (!Sunset.day)
        panel.position = Input.mousePosition + new Vector3 (15, 15);
    }
}