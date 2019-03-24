using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollosionWithPlayer : MonoBehaviour        //скрипт проверки всех коллизий игрока с объектами
{
    RedCoinEffect RedEffect;
    PlayerStats stats;
    public GameObject GAMER;
    

    void Start()
    {
        stats = GAMER.GetComponent<PlayerStats>();
        RedEffect = GetComponent<RedCoinEffect>();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Coin" || other.gameObject.name == "Coin(Clone)")//уничтожение монеты и инкримент счётчика
        {
            Destroy(other.gameObject);
            stats.CountCoin++;         
        }
        if (other.gameObject.name == "RedCoin(Clone)")               //уничтожене красной монеты и активация эффекта
        {
            Destroy(other.gameObject);
            RedEffect.red_coin_activation();
        }
    }
}