using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollosionWithPlayer : MonoBehaviour        //скрипт проверки всех коллизий игрока с объектами
{
    RedCoinEffect RedEffect;
    Player igrok;
    public GameObject GAMER;
    

    void Start()
    {
        igrok = GAMER.GetComponent<Player>();
        RedEffect = GetComponent<RedCoinEffect>();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Coin" || other.gameObject.name == "Coin(Clone)")//уничтожение монеты и инкримент счётчика
        {
            Destroy(other.gameObject);
            igrok.CountCoin++;         
        }
        if (other.gameObject.name == "RedCoin(Clone)")               //уничтожене красной монеты и активация эффекта
        {
            Destroy(other.gameObject);
            RedEffect.red_coin_activation();
        }
    }
}