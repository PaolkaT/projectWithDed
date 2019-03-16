using System;
using System.Collections;
using UnityEngine;

public class _Destroy : MonoBehaviour
{    
    public static int count_yellow = 0;
    float red_coin_effect_time = 5f;
    bool red_coin_active = false;
    Color origin;
    float time_now=0f;

    void red_coin_activation()
    {  
        Move.player_speed *= 2;
        red_coin_active = true;
    }

    void red_coin_disactivation()
    {
        GetComponent<Renderer>().material.color = origin;
        Move.player_speed /= 2;
        red_coin_active = false;
    }

    void Start()
    {
        origin = GetComponent<Renderer>().material.color;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Coin" || other.name == "Coin(Clone)")
        {           
            Destroy(other.gameObject);
            count_yellow++;
        }
        if (other.name == "RedCoin(Clone)")
        {
            Destroy(other.gameObject);
            red_coin_activation();
        }
    }

     void Update()
    {
        if (red_coin_active)
        {
            GetComponent<Renderer>().material.color = new Color(UnityEngine.Random.value, UnityEngine.Random.value,UnityEngine.Random.value, 1.0f);
            time_now += Time.deltaTime;
            if (time_now >= red_coin_effect_time)
                red_coin_disactivation();
        }
    }
}
        