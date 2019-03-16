using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    public static float player_speed=6f;
    void Update()
    {
        float a;
        a = Input.GetAxis("Vertical");
        if (a > 0) transform.Translate(transform.forward * player_speed * Time.deltaTime);
        if (a < 0) transform.Translate(transform.forward * -player_speed * Time.deltaTime);
        a = Input.GetAxis("Horizontal");
        if (a > 0) transform.Translate(transform.right * player_speed * Time.deltaTime);
        if (a < 0) transform.Translate(transform.right * -player_speed * Time.deltaTime);
    }
}