using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuddleScr : MonoBehaviour
{
    void OnCollisionEnter(Collision collision) //столкновение с лужей
    {
        if (collision.collider.tag == "Player") //если игрок наступил в лужу
            GameObject.FindGameObjectWithTag("Player").GetComponent<Destr>().TakeDamage(1); //нанесение урона игроку
        if (collision.collider.tag == "enemy") //если моб наступил в лужу
            Destroy(GameObject.FindGameObjectWithTag("enemy")); //уничтожение мобов
    }
}
