using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class PlayerMovement : MonoBehaviour
{
    public bool MovementEnabled;
    private bool isFacingRight = false;
    public static event Action OnPlayerDamaged;
    public float horizontal;
    public float vertical;
    public Rigidbody2D rB;
    private void Awake()
    {
        MovementEnabled = true;
    }
    public void EnableMovement()
    {
        MovementEnabled = true;
    }
    public void OneSecDisableMovement()
    {
        MovementEnabled = false;
        StartCoroutine(onesec());
    }
    public void TwoSecDisableMovement()
    {
        MovementEnabled = false;
        StartCoroutine(twosec());
    }
    IEnumerator onesec()
    {
        yield return new WaitForSeconds(1);
        EnableMovement();
    }
    IEnumerator twosec()
    {
        yield return new WaitForSeconds(2);
        EnableMovement();
    }
    public void Move(Vector2 context)
    {
        if (MovementEnabled)
        {
            horizontal = context.x;
            vertical = context.y;
        }
    }
    void Update()
    {
        rB.velocity = new Vector2(horizontal * 1.5f, rB.velocity.y);
        rB.velocity = new Vector2(rB.velocity.x, vertical * 1.5f);
        if (!isFacingRight && horizontal > 0f)
            Flip();
        else if (isFacingRight && horizontal < 0f) Flip();
    }
    private void Flip()
    {
        isFacingRight = !isFacingRight;
        var localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }
}
