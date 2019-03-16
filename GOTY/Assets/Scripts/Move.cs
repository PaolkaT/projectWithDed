using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    void Update()
    {
        float a;
        a = Input.GetAxis("Vertical");
        if (a > 0) transform.Translate(transform.forward * 6.0f * Time.deltaTime);
        if (a < 0) transform.Translate(transform.forward * -6.0f * Time.deltaTime);
        a = Input.GetAxis("Horizontal");
        if (a > 0) transform.Translate(transform.right * 6.0f * Time.deltaTime);
        if (a < 0) transform.Translate(transform.right * -6.0f * Time.deltaTime);
    }
}