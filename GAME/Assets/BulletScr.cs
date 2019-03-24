using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScr : MonoBehaviour
{
    Transform target; //цель
    float speed = 50; //скорость полета пули
    int damage = 1; //урон от одной пули

    void Update()
    {
        Move();
    }

    public void SetTarget(Transform enemy)
    {
        target = enemy;
    }

    public void Move()
    {
        if (target) //существование
        {
            if (Vector3.Distance(transform.position, target.position) < 0.1f) //если пуля достигла цели
            {
                target.GetComponent<Destr>().TakeDamage(damage);
                Destroy(gameObject); //удаление пули
            }
            else
            {
                Vector3 dir = target.position - transform.position;
                transform.Translate(dir.normalized * Time.deltaTime * speed);
            }
        }
    }
}
