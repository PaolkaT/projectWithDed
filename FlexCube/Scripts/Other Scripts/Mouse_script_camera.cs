using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_script_camera : MonoBehaviour
{
    public float sensitivey = 3f;

    public float minY = -15;
    public float maxY = 30;

    private Quaternion originalRot;
    private float rotY = 0;

    private void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb)
            rb.freezeRotation = true;
        originalRot = transform.localRotation;
    }
    private void Update()
    {
        rotY += Input.GetAxis("Mouse Y") * sensitivey;

        rotY = rotY % 360;

        rotY = Mathf.Clamp(rotY, minY, maxY);

        Quaternion yQuaternion = Quaternion.AngleAxis(rotY, Vector3.left);

        transform.localRotation = originalRot * yQuaternion;
    }
}
