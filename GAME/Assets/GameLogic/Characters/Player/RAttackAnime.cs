using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RAttackAnime : MonoBehaviour
{
    public Transform Arm;
    public AnimationClip Attack_1;
    void Start()
    {
        
    }

    void Update()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            Arm.GetComponent<Animator>().Play("ArmAttack");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Arm.GetComponent<Animator>().Play("New State");
        }
    }
}
