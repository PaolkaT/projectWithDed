using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HatButton : MonoBehaviour
{
    public GameObject Player;
    public Button BuyHat;
    public GameObject button;
    public GameObject hat;
    PlayerStats stats;

    void ButtonClick()
    {
        if (stats.CountCoin >= 5)
        {
            stats.CountCoin -= 5;
            hat.SetActive(true);
        }
    }
        void Start()
    {
        stats = Player.GetComponent<PlayerStats>();
        BuyHat.onClick.AddListener(ButtonClick);
        button.SetActive(false);
    }

    
    void Update()
    {
        if (Sunset.day == false)
            button.SetActive(true);

        if (Sunset.day)
            button.SetActive(false);

    }
}
