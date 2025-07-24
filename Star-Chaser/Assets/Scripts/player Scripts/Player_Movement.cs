using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float Speed = 5;
    private Rigidbody2D Rb;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       float Move_X = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(Move_X, 0);

      Rb.velocity = movement * Speed;
    }
}
