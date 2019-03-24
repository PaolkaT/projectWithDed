using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillManager : MonoBehaviour
{
    public Image SkillQ;
    public Image SkillE;
    bool isQ=false;
    bool isE=false;
  

    public KeyCode AddSkill(Sprite img)
    {
        if (isQ == false)
        {
            isQ = true;
            SkillQ.overrideSprite = img;
            return KeyCode.Q;
        }
        else if (isE == false)
        {
            isE = true;
            SkillE.sprite = img;
            return KeyCode.E;
        }
        else return KeyCode.Escape;
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
