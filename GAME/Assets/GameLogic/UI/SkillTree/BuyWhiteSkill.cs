using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyWhiteSkill : MonoBehaviour
{
    public GameObject player;
    public Button button;
    void BuySkill()
    {
        player.AddComponent<WhiteSkill>();

    }
    
    void Awake()
    {
        button.onClick.AddListener(BuySkill);
    }

    
    void Update()
    {
        
    }
}
