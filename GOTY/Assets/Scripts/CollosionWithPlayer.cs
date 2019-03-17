using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollosionWithPlayer : MonoBehaviour        //скрипт проверки всех коллизий игрока с объектами
{
    RedCoinEffect RedEffect;
    Player igrok;

    void Start()
    {
        igrok = GetComponent<Player>();
        RedEffect = GetComponent<RedCoinEffect>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Coin" || other.name == "Coin(Clone)")//уничтожение монеты и инкримент счётчика
        {
            Destroy(other.gameObject);
            igrok.CountCoin++;         
        }
        if (other.name == "RedCoin(Clone)")               //уничтожене красной монеты и активация эффекта
        {
            Destroy(other.gameObject);
            RedEffect.red_coin_activation();
        }
    }
}