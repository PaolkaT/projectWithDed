﻿using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class Destr : MonoBehaviour
{

    [Range(0.0f, 10.0f)]
    public float rad; //радиус действия способности
    public float StartDelay = 0f; //начальное значение задержки
    public float Delay = 0f; //обновляемое значение задержки 
    public PlayerStats player;
    Renderer rend;
    Color original;
    RedCoinEffect eff;
    public AngryCube_test bot;

    void Start()
    {
        eff = GetComponent<RedCoinEffect>();
        rend = GetComponentInParent<Renderer>();
        player = GetComponentInParent<PlayerStats>();
        original = rend.material.color;
        
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            player.CountCoin++;
        }
        if (collision.gameObject.tag == "Red")               //уничтожене красной монеты и активация эффекта
        {
            Destroy(collision.gameObject);
            eff.red_coin_activation();
        }
        if (collision.gameObject.tag == "enemy") //если враг
        { 
            player.hp -= 1; //уменьшение хр
            Destroy(collision.gameObject); //уничтожение врага
        }
    }

    void OnTriggerStay(Collider other)
    {
        if ((Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(0)) && Delay < 0 && other.tag == "enemy") //условие действия способности
        {
            GameObject[] list = GameObject.FindGameObjectsWithTag("enemy");
            int i = list.Length;
            while (--i >= 0)
            {
                GameObject obj = list[i];
                bot = obj.GetComponent<AngryCube_test>();
                if (Vector3.Distance(obj.transform.position, gameObject.transform.position) < rad + 0.5f) //находится ли враг внутри радиуса действия способности
                    bot.bot_hp--;
            }
            gameObject.GetComponent<Renderer>().material.color = Color.black; //обозначение перезарядки цветом
            RefreshDelay(); //обновление перезарядки
        }
    }
    
    void Update()
    {
        if (player.hp <= 0) //условие смерти ГГ
            Destroy(gameObject); //уничтожение
        Delay -= Time.deltaTime; //уменьшение времени перезарядки
        if (Delay > 0) return; //время перезарядки способности
        rend.material.color = original; // возвращение изходного цвета при окончании перезарядки способности
    }

    void RefreshDelay() //обновление задержки
    {
        Delay = StartDelay;
    }

    public void TakeDamage(int damage) //получение урона
    {
        player.hp -= damage;
    }
}