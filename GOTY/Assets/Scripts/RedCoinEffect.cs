using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCoinEffect : MonoBehaviour            //Скрипт эффекта дял красной монеты
{
    Player igrok;
    Renderer rend;
    float red_coin_effect_time = 5f;                //время действия красной монеты
    bool red_coin_active = false;                      //  состояние активированности эффекта красной монеты
    Color origin;                                    //оригинальный цвет куба
    float time_now = 0f;
    public void red_coin_activation()                           //активация эффекта красной монеты
    {
        if (red_coin_active == false)                              //эффект не может примениться дважды
        {
            origin = rend.material.color;
            igrok.PlayerSpeed *= 2;
            red_coin_active = true;
        }
    }

    public void red_coin_disactivation()                                                     //дезактивация эффекта красной монеты
    {
        rend.material.color = origin;
        igrok.PlayerSpeed /= 2;
        red_coin_active = false;
    }
    void Start()
    {
        igrok = GetComponent<Player>();          //получения компонентов игрока
        rend = GetComponent<Renderer>();

    }

    void Update()
    {
        if (red_coin_active)
        {
            rend.material.color = new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, 1.0f);            //каждый кадр случайный цвет
            time_now += Time.deltaTime;//время действия способности
            if (time_now >= red_coin_effect_time)//эффект прошёл
            {
                red_coin_disactivation();
                time_now = 0;
            }
        }
    }
}
