using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    void Start()
    {
        
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) transform.Translate(transform.forward * 6.0f * Time.deltaTime, Space.World);

        if (Input.GetKey(KeyCode.S)) transform.Translate(transform.forward * -6.0f * Time.deltaTime, Space.World);

        if (Input.GetKey(KeyCode.A)) transform.Translate(transform.right * -6.0f * Time.deltaTime, Space.World);

        if (Input.GetKey(KeyCode.D)) transform.Translate(transform.right * 6.0f * Time.deltaTime, Space.World);

        if (Input.GetKey(KeyCode.Z)) transform.Translate(transform.up * -6.0f * Time.deltaTime, Space.World);

        if (Input.GetKey(KeyCode.X)) transform.Translate(transform.up * 6.0f * Time.deltaTime, Space.World);
    }
}
