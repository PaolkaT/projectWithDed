using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour   //Скрипт для передвижения игрока
{
    Player gamer;
    public float speed;

     void Start()
    {
        gamer = GetComponent<Player>();
    }
    void Update()
    {
        if (Sunset.day)
        {
            speed = gamer.PlayerSpeed;
            float a;
            a = Input.GetAxis("Vertical");
            if (a > 0) transform.Translate(transform.forward * speed * Time.deltaTime);
            if (a < 0) transform.Translate(transform.forward * -speed * Time.deltaTime);
            a = Input.GetAxis("Horizontal");
            if (a > 0) transform.Translate(transform.right * speed * Time.deltaTime);
            if (a < 0) transform.Translate(transform.right * -speed * Time.deltaTime);
        }
    }   
}
