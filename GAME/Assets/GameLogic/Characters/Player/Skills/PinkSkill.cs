using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkSkill : AbstractAbility
{
    SkillManager manager;
    KeyCode key;
    Color col = new Color(196, 0, 236, 255);
    public float CD = 3f;
    public float cast = 0f;
    public float time = 1f;
    public float timenow;
    public string SkillName = "PinkSkill";
    public Sprite SkillIMG;
    public string Desc = "Pink";
    public float Delay;
    Color origin;
    Renderer rend;
    bool isactive = false;

    public override float Cooldown
    {
        get
        {
            return CD;
        }
        set
        {
            Cooldown = CD;
        }
    }

    public override float Casttime
    {
        get
        {
            return cast;
        }
        set
        {
            Casttime = cast;
        }
    }

    public override float AbilityTime
    {
        get
        {
            return time;
        }
        set
        {
            AbilityTime = time;
        }
    }

    public override string AbilityName
    {
        get
        {
            return SkillName;
        }
        set
        {
            AbilityName = SkillName;
        }
    }

    public override Sprite AbilityIMG
    {
        get
        {
            return SkillIMG;
        }
        set
        {
            AbilityIMG = SkillIMG;
        }

    }

    public override string AbilityDescription
    {
        get
        {
            return Desc;
        }
        set
        {
            AbilityName = Desc;
        }
    }


    public override void SkillActivation()
    {
        isactive = true;
        timenow = 0f;

    }
    public override void SkillDisactivation()
    {
        isactive = false;
        rend.material.color = origin;
    }

    void Start()
    {
        SkillIMG = Resources.Load<Sprite>("Textures/Pink");
        manager = GetComponent<SkillManager>();
        key = manager.AddSkill(AbilityIMG);
        rend = GetComponent<Renderer>();
        origin = rend.material.color;
        Delay = Cooldown;
    }


    void Update()
    {
        Delay -= Time.deltaTime;
        if (Input.GetKeyDown(key) && Delay < 0)
        {
            SkillActivation();
            Delay = Cooldown;
        }
        if (isactive)
        {
            rend.material.color = col;
            timenow += Time.deltaTime;
            if (timenow > AbilityTime)
                SkillDisactivation();
        }
    }
}
