using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hp : MonoBehaviour
{

    public Text hp;
    public GameObject Player;
    PlayerStats stats;

    void Start()
    {
        stats = Player.GetComponent<PlayerStats>();
        
    }

    
    void Update()
    {
        hp.text = $"Здоровье: {stats.hp}";
    }
}
