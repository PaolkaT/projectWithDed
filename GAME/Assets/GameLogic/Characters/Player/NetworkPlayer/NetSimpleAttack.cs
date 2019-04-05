using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetSimpleAttack : NetworkBehaviour
{
    public float m_Cooldown = 0.5f;
    private float cooldown = 0;
    public int AttackPower = 1;
    public GameObject colliderCube;
    public NetColliderCheck CC_simpleAttack;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Attack()
    {
        cooldown = m_Cooldown;
        CmdAttack();
    }

    [Command]
    void CmdAttack()
    {
        int cnt = 0;
        List<GameObject> colGameObjects;
        colGameObjects = CC_simpleAttack.GetCollidingObjects();
        RpcTest(colGameObjects.Count);
        foreach (var obj in colGameObjects)
        {
            var HP = obj.GetComponent<NetHP>();
            if (HP)
            {
                HP.DealDamage(AttackPower);
            }
        }
    }

    [ClientRpc]
    void RpcTest(int cnt)
    {
        print(cnt);
    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        if (!isLocalPlayer) return;
        if ((Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(0)) && cooldown <= 0)
        {
            Attack();
        }
    }
}
