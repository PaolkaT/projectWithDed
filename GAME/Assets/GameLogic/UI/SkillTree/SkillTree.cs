using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTree : MonoBehaviour
{
    bool IsActive;
    public GameObject Tree;
    void Start()
    {
        Tree.SetActive(false);
    }

  
    void Update()
    {
        IsActive = Tree.activeInHierarchy;
        if ( IsActive ==  false && Input.GetKeyDown(KeyCode.T))
            Tree.SetActive(true);
        if (IsActive == true && Input.GetKeyDown(KeyCode.T))
            Tree.SetActive(false);
    }
}
