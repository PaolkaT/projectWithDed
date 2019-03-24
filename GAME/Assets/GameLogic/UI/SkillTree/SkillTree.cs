using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTree : MonoBehaviour
{
    public GameObject Tree;
    void Start()
    {
        Tree.SetActive(false);
    }

  
    void Update()
    {
        if (Sunset.day == false)
            Tree.SetActive(true);
    }
}
