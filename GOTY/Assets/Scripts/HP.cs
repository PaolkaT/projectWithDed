using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    Text text_hp;
    Destr destrComp;
    public GameObject player;

    void Start()
    {
        destrComp = player.GetComponent<Destr>();
    }

    void Awake()
    {
        text_hp = GetComponent<Text>();
    }

    void Update()
    {
        text_hp.text = "HP: " + destrComp.hp; //отображение текущего хп
    }
}
