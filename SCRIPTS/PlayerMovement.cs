using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class PlayerMovement : MonoBehaviour
{
    public static event Action OnPlayerDamaged;
    public float horizontal;
    public float vertical;
    public Rigidbody2D rB;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Move(Vector2 context)
    {
        Debug.Log("MoveCalled");
        horizontal = context.x;
        vertical = context.y;
    }
    // Update is called once per frame
    void Update()
    {
        rB.velocity = new Vector2(horizontal * 1, rB.velocity.y);
        rB.velocity = new Vector2(rB.velocity.x, vertical * 1);
    }
}
