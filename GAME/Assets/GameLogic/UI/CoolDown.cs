using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoolDown : MonoBehaviour
{
    public GameObject Player;
    Destr skill;
    public Text cd;

    void Start()
    {
        skill = Player.GetComponent<Destr>();
    }
    

    void Update()
    {
        if (skill.Delay >= 0)
            cd.text = "CD: " + (int)skill.Delay;
        else
            cd.text = "CD: " + 0;
    }
}
