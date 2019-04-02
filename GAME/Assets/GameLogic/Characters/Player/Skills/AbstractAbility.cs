using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class AbstractAbility : MonoBehaviour
{
    public abstract float Casttime { get; set; }
    public abstract float Cooldown { get; set; }
    public abstract float AbilityTime { get; set;}
    public abstract void SkillActivation();
    public abstract void SkillDisactivation();
    public abstract string AbilityName { get; set; }
    public abstract Sprite AbilityIMG { get; set; }
    public abstract string AbilityDescription { get; set; }
    
}
