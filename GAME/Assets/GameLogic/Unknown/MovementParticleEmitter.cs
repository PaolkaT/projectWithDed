using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementParticleEmitter : MonoBehaviour
{
    ParticleSystem PS;
    // Start is called before the first frame update
    void Awake()
    {
        PS = GetComponent<ParticleSystem>();
    }

    public void Switch(bool on)
    {
        if (on && !PS.isPlaying) PS.Play() ;
        if (!on) PS.Stop();
    }

    public void Options()
    {

    }
}
