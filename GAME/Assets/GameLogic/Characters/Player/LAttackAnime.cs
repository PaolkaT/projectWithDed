using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LAttackAnime : MonoBehaviour
{
    public Transform Arm;
    public AnimationClip Attack_1;
    void Start()
    {

    }

    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            Arm.GetComponent<Animator>().Play("ArmAttack");
        }
        if (Input.GetMouseButtonUp(1))
        {
            Arm.GetComponent<Animator>().Play("New State");
        }
    }
}
