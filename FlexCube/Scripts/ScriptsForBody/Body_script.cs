using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body_script : MonoBehaviour
{
    public float rot_speed = 5f;
    void Start()
    {

    }

    void Update()
    {
        var rot = gameObject.transform.rotation.eulerAngles;
        float y_rot = 0;
        y_rot += Input.GetAxis("Vertical");
        transform.rotation = Quaternion.Euler(rot.x, rot.y + y_rot * Mathf.Sin(Time.time * 8) * rot_speed, rot.z);
    }
}
