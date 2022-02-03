using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rig;

    public float Speed, JumpForce;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        Vector3 movemant = new Vector3(Input.GetAxis("Horizontal"), 0F, 0F);
        transform.position += movemant * Time.deltaTime * Speed;
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump"))
        {
            rig.AddForce(new Vector2(0F, JumpForce), ForceMode2D.Impulse);
        }
    }
}
