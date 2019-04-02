using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryCube_test : MonoBehaviour
{
    private float nextActionTime = 0.5f;
    public GameObject color;
    public GameObject Bot;
    public float floatrange = 20.0f;
    public float timeToNextStep = 0.005f;
    public float bot_skill_cast_range = 20f;
    public float bot_skill_cd = 3f;
    public float bot_skill_Delay = -0.2f;
    public float bot_skill_cast_delay = 3f;
    public PlayerStats player;
    void Start()
    {
        color = GameObject.FindGameObjectWithTag("Player");
        player = color.GetComponent<PlayerStats>();
    }

    void Update()
    {
        if (Sunset.day)
        {
            bot_skill_Delay -= Time.deltaTime;
            if ((Time.time > nextActionTime) && (Vector3.Distance(color.transform.position, transform.position) > floatrange))
            {
                float rx = Random.Range(-4f, 4f);
                float rz = Random.Range(-4f, 4f);
                transform.Translate(new Vector3(rx, 0, rz) * Time.deltaTime * 5);
                nextActionTime += timeToNextStep;
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, color.transform.position, Time.deltaTime);
                if (Vector3.Distance(color.transform.position, transform.position) < bot_skill_cast_range && bot_skill_Delay <= 0)
                {
                    bot_skill_cast_delay -= Time.deltaTime;
                    if (bot_skill_cast_delay >= 2 && bot_skill_cast_delay <= 3)
                        Bot.GetComponent<Renderer>().material.color = Color.green;
                    else if (bot_skill_cast_delay >= 1 && bot_skill_cast_delay < 2)
                        Bot.GetComponent<Renderer>().material.color = Color.yellow;
                    else if (bot_skill_cast_delay > 0 && bot_skill_cast_delay < 1)
                        Bot.GetComponent<Renderer>().material.color = Color.magenta;
                    if (bot_skill_cast_delay <= 0)
                    {
                        Bot.GetComponent<Renderer>().material.color = Color.black;
                        RefreshBotDelay();
                        Bot.GetComponent<Renderer>().material.color = Color.red;
                        bot_skill_cast_delay = 3f;
                    }
                }
                else if (Vector3.Distance(color.transform.position, transform.position) > bot_skill_cast_range)
                {
                    bot_skill_cast_delay = 3f;
                    RefreshBotDelay();
                    Bot.GetComponent<Renderer>().material.color = Color.red;
                }

            }
        }
    }
    void RefreshBotDelay()
    {
        bot_skill_Delay = bot_skill_cd;
    }
}