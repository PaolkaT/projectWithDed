using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour   //Скрипт для передвижения игрока
{
    PlayerStats stats;
    public float speed;

     void Start()
    {
        stats = GetComponent<PlayerStats>();
    }
    void Update()
    {
        if (Sunset.day)
        {
            speed = stats.PlayerSpeed;
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
