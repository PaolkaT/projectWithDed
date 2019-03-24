using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_povorot_body : MonoBehaviour
{
    public float sensitiveX = 3f;

    public float minX = -360;
    public float maxX = 360;

    private Quaternion originalRot;
    private float rotX = 0;

    private void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb)
            rb.freezeRotation = true;
        originalRot = transform.localRotation;
    }
    private void Update()
    {
        rotX += Input.GetAxis("Mouse X") * sensitiveX;

        rotX = rotX % 360;

        rotX = Mathf.Clamp(rotX, minX, maxX);

        Quaternion xQuaternion = Quaternion.AngleAxis(rotX, Vector3.up);

        transform.localRotation = originalRot * xQuaternion;
    }
}
