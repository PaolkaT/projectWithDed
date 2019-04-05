using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetHP : NetworkBehaviour
{
    [SyncVar]
    public int hp;

    void Start()
    {
        
    }

    public void DealDamage(int damage)
    {
        if (!isServer) return;
        hp -= damage;
        if (hp < 0)
        {
            DestroyThis();
        }
    }

    private void DestroyThis()
    {
        NetworkServer.Destroy(gameObject);
    }
}
