using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillManager : MonoBehaviour
{
    public Image Skill1;
    public Image Skill2;
    public Image Skill3;
    public Image Skill4;
    public Image Skill5;
    public Image Skill6;
    public Image Skill7;
    public Image Skill8;
    bool is1 = false;
    bool is2 = false;
    bool is3 = false;
    bool is4 = false;
    bool is5 = false;
    bool is6 = false;
    bool is7 = false;
    bool is8 = false;


    public KeyCode AddSkill(Sprite img)
    {
        if (is1 == false)
        {
            is1 = true;
            Skill1.sprite = img;
            return KeyCode.Alpha1;
        }
        else if (is2 == false)
        {
            is2 = true;
            Skill2.sprite = img;
            return KeyCode.Alpha2;
        }
        else if (is3 == false)
        {
            is3 = true;
            Skill3.sprite = img;
            return KeyCode.Alpha3;
        }
        else if (is4 == false)
        {
            is4 = true;
            Skill4.sprite = img;
            return KeyCode.Alpha4;
        }
        else if (is5 == false)
        {
            is5 = true;
            Skill5.sprite = img;
            return KeyCode.Alpha5;
        }
        else if (is6 == false)
        {
            is6 = true;
            Skill6.sprite = img;
            return KeyCode.Alpha6;
        }
        else if (is7 == false)
        {
            is7 = true;
            Skill7.sprite = img;
            return KeyCode.Alpha7;
        }
        else if (is8 == false)
        {
            is8 = true;
            Skill8.sprite = img;
            return KeyCode.Alpha8;
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
