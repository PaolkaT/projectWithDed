using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyCyanSkill : MonoBehaviour
{
    public Image Learned;
    public GameObject player;
    PlayerStats stats;
    public Button button;
    void BuySkill()
    {
        if (stats.SKillPoint > 0 && Learned.color == Color.gray)
        {
            stats.SKillPoint--;
            player.AddComponent<CyanSkill>();
            Learned.color = Color.white;          
        }

    }

    void Awake()
    {
        button.onClick.AddListener(BuySkill);
    }

    void Start()
    {
        stats = player.GetComponent<PlayerStats>();
    }

    void Update()
    {

    }
}