using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class Destr : MonoBehaviour
{

    [Range(0.0f, 10.0f)]
    public float rad; //радиус действия способности
    public float StartDelay = 3f; //начальное значение задержки
    public float Delay = 0f; //обновляемое значение задержки
    public GameObject explosion; //игровой объект
    public GameObject playerExplosion; //игровой объект
    public int hp = 3; //очки здоровья
    GameObject player;

    void Start()
    {

    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy") //если враг
        { 
            hp -= 1; //уменьшение хр
            Destroy(collision.gameObject); //уничтожение врага
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Q) && Delay < 0 && other.tag == "enemy") //условие действия способности
        {
            GameObject[] list = GameObject.FindGameObjectsWithTag("enemy");
            int i = list.Length;
            while (--i >= 0)
            {
                GameObject obj = list[i];
                if (Vector3.Distance(obj.transform.position, playerExplosion.transform.position) < rad + 0.5f) //находится ли враг внутри радиуса действия способности
                    Destroy(obj.gameObject); //уничтожение врага
            }
            playerExplosion.GetComponent<Renderer>().material.color = Color.black; //обозначение перезарядки цветом
            RefreshDelay(); //обновление перезарядки
        }
    }
    
    void Update()
    {
        if (hp <= 0) //условие смерти ГГ
            Destroy(playerExplosion); //уничтожение
        Delay -= Time.deltaTime; //уменьшение времени перезарядки
        if (Delay > 0) return; //время перезарядки способности
        playerExplosion.GetComponent<Renderer>().material.color = Color.white; // возвращение изходного цвета при окончании перезарядки способности
    }

    void RefreshDelay() //обновление задержки
    {
        Delay = StartDelay;
    }
}