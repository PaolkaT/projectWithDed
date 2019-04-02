using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.red; //метеорит "горячий"
    }

    void OnCollisionEnter(Collision collision) //столкновение
    {
        if ((gameObject.GetComponent<Renderer>().material.color == Color.red) && (collision.collider.tag == "Player")) //если метеорит "горячий" и соприкасается с игроком
            GameObject.FindGameObjectWithTag("Player").GetComponent<Destr>().TakeDamage(1); //нанесение урона игроку
        if ((gameObject.GetComponent<Renderer>().material.color == Color.red) && (collision.collider.tag == "enemy")) //если метеорит "горячий" и соприкасается с мобом
            Destroy(GameObject.FindGameObjectWithTag("enemy")); //уничтожение мобов
        GetComponent<AudioSource>().Play(); //звук удара о землю
        Invoke("Cooling", 10); //остывание
        Invoke("Delete", 20); //исчезновение
    }

    void Cooling() //остывание
    {
        GetComponent<Renderer>().material.color = Color.green; //смена цвета при остывании
    }

    void Delete() //исчезновение
    {
        Destroy(gameObject); //уничтожение объекта
    }

}
