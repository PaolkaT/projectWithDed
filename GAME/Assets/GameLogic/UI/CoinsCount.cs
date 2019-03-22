using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsCount : MonoBehaviour
{
    public GameObject player;
    PlayerStats stats;
    public Text count;
    void Start()
    {
        stats = player.GetComponent<PlayerStats>();
    }

    void Update()
    {
        count.text = $"Количество собранных  монет: {stats.CountCoin}";
    }
}
