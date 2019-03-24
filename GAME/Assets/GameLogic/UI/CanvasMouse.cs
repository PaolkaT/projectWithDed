using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CanvasMouse : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public Player player;
    public GameObject hat;
    public GameObject whitehat;
    public GameObject hattext;
    public Text hattexttext;
    public Transform panel;
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (hat.name == "hat")
            hattexttext.text = ("Шляпа за 5 монет!");
        if (hat.name == "whitehat")
            hattexttext.text = ("Ультракрутая и модная шляпа за 10 монет!");
        hattext.SetActive(true);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        hattext.SetActive(false);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (hat.name == "hat")
        {
            player.CountCoin -= 5;
            hat.SetActive(true);
        }
        if (hat.name == "whitehat")
        {
            player.CountCoin -= 10;
            whitehat.SetActive(true);
        }
    }
    void Update()
    {
        panel.position = Input.mousePosition + new Vector3 (15, 15);
    }
}