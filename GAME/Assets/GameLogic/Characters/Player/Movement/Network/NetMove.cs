using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class NetMove : NetworkBehaviour   //Скрипт для передвижения игрока
{
    PlayerStats stats;
    MovementParticleEmitter MPE;
    private float MPETimer;

    public bool TEAM_VIEWER_USED = true;

    private float speed;
    private Vector3 lastMousePos = new Vector3();

    void Start()
    {
        stats = GetComponent<PlayerStats>();
        MPE = GetComponent<MovementParticleEmitter>();
    }

    void MoveByButton(char key, Vector3 dir, ref bool moved)
    {
        if (Input.inputString.IndexOf(key) != -1)
        {
            transform.Translate(dir * speed * 10 * Time.deltaTime, Space.World);
            moved = true;
        }
    }

    void Update()
    {
        if (!isLocalPlayer) return;

        if (TEAM_VIEWER_USED)
        {
            MPETimer += Time.deltaTime;
            if (Sunset.day)
            {
                speed = stats.PlayerSpeed;
                bool moved = false;
                MoveByButton('w', transform.forward, ref moved);
                MoveByButton('d', transform.right, ref moved);
                MoveByButton('a', -transform.right, ref moved);
                MoveByButton('s', -transform.forward, ref moved);
                if (moved)
                {
                    MPE.Switch(on: true);
                    MPETimer = 0;
                }
                else if (MPETimer > 0.5)
                    MPE.Switch(on: false);
                int sign = Input.mousePosition.x > lastMousePos.x ? 1 : -1;
                float dx = Vector3.Distance(Input.mousePosition, lastMousePos);
                transform.Rotate(Vector3.up, sign * dx / 10, Space.World);
                lastMousePos = Input.mousePosition;
            }
        }
        else
        {

        }
    }
}
