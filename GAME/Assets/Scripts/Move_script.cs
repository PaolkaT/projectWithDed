using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_script : MonoBehaviour
{
    public float speed=0;
    public float jumpSpeed = 15f;
    Player igrok;
    MovementParticleEmitter MPE;
    // Start is called before the first frame update
    void Start()
    {
        igrok = GetComponent<Player>();
        MPE = GetComponent<MovementParticleEmitter>();
        speed = igrok.PlayerSpeed;
    }

    // Возвращет 1 если движение было, 0 в противном случае
    bool MoveAxis(string name, Vector3 dirMove, bool movement)
    {
        float move = Input.GetAxis(name);
        movement = movement | (move != 0);
        if (name == "Jump" && move > 0)
            transform.Translate(dirMove * jumpSpeed * Time.deltaTime);
        if (move > 0)
            transform.Translate(dirMove * speed * Time.deltaTime);
        if (move < 0)
            transform.Translate(dirMove * -speed * Time.deltaTime);
        return movement;
    }

    // Update is called once per frame
    void Update()
    {
        speed = igrok.PlayerSpeed;
        bool movement = false;
        movement = MoveAxis("Vertical", transform.forward, movement);
        movement = MoveAxis("Horizontal", transform.right, movement);
        movement = MoveAxis("Jump", transform.up, movement);
        MPE.Switch(movement);
        print(movement);
    }
}
