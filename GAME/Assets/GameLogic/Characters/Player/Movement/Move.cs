using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour   //Скрипт для передвижения игрока
{
    PlayerStats stats;
    public float speed;
    float povorot = 2f;
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
            var dx = Input.GetAxis("Mouse X");
            transform.Rotate(Vector3.up, dx, Space.World);
            a = Input.GetAxis("Vertical");
            if (a > 0) transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if (a < 0) transform.Translate(Vector3.forward * -speed * Time.deltaTime);
            a = Input.GetAxis("Horizontal");
            if (a > 0) transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (a < 0) transform.Translate(Vector3.right * -speed * Time.deltaTime);
        }
    }   
}