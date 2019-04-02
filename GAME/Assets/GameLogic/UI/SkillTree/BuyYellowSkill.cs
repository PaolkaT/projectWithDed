using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyYellowSkill : MonoBehaviour
{
    bool open = false;
    public Image Next;
    public Image Prev1;
    public Image Prev2;
    public Image Learned;
    public GameObject player;
    PlayerStats stats;
    public Button button;
    void BuySkill()
    {
        if (stats.SKillPoint > 0 && Learned.color == Color.gray)
        {
            stats.SKillPoint--;
            player.AddComponent<YellowSkill>();
            Learned.color = Color.white;
            Next.color = Color.gray;
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
        if (Prev1.color == Color.white && Prev2.color == Color.white && open == false)
        {
            Learned.color = Color.gray;
            open = true;
        }
    }
}
