using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetBodyCollider : MonoBehaviour
{
    NetDestr parentDestr;
    // Start is called before the first frame update
    void Start()
    {
        parentDestr = transform.parent.gameObject.GetComponent<NetDestr>();
    }

    void OnTriggerEnter(Collider collision)
    {
        parentDestr.ReactCollision(collision);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
