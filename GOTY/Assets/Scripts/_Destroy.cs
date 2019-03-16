using System;
using System.Collections;
using UnityEngine;

public class _Destroy : MonoBehaviour
{    
    public static int count_yellow = 0;//количество собранных монет
    float red_coin_effect_time = 5f;//время действия красной монеты
    bool red_coin_active = false ; //  состояние активированности эффекта красной монеты
    Color origin;//оригинальный цвет куба
    float time_now=0f;

    void red_coin_activation()//активация эффекта красной монеты
    {
        if (red_coin_active == false)//эффект не может примениться дважды
        {
            Move.player_speed *= 2;
            red_coin_active = true;
        }
    }

    void red_coin_disactivation()//дезактивация эффекта красной монеты
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
            Destroy(other.gameObject);//уничтожение монеты и инкримент счётчика
            count_yellow++;
        }
        if (other.name == "RedCoin(Clone)")
        {
            Destroy(other.gameObject);//уничтожене красной монета и активация эффекта
            red_coin_activation();
        }
    }

     void Update()
    {
        if (red_coin_active)
        {
            GetComponent<Renderer>().material.color = new Color(UnityEngine.Random.value, UnityEngine.Random.value,UnityEngine.Random.value, 1.0f);//каждый кадр случайный цвет
            time_now += Time.deltaTime;//время действия способности
            if (time_now >= red_coin_effect_time)//эффект прошёл
            {
                red_coin_disactivation();
                time_now = 0;
            }
            
        }
    }
}
        