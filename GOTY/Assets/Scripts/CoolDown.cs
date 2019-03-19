using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoolDown : MonoBehaviour
{
    Text text;
    Destr destrComp;
    public GameObject player;

    void Start()
    {
        destrComp = player.GetComponent<Destr>();
    }

    void Awake()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        if (destrComp.Delay >= 0)
            text.text = "CD: " + (int)destrComp.Delay; //отображение текущего кд способности
        else
            text.text = "CD: " + 0; //отображение текущего кд способности
    }
}
