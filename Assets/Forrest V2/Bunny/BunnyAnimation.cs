using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyAnimation : MonoBehaviour
{
    private bool isFacingRight = false;

    public SpriteRenderer SR;
    public Rigidbody2D BunnyRB;
    public Animator BunnyAnimator;
    private void FixedUpdate()
    {
        if (!isFacingRight && BunnyRB.velocity.x > 0f)
            Flip();
        else if (isFacingRight && BunnyRB.velocity.x < 0f) Flip();
        if (BunnyRB.velocity.x >0.01|| BunnyRB.velocity.x < -0.01)
        {
            BunnyAnimator.Play("BunnyWalk");
        }
        else if (BunnyRB.velocity.y > 0.01 || BunnyRB.velocity.y < -0.01)
        {
            BunnyAnimator.Play("BunnyWalk");
        }
        else
        {
            BunnyAnimator.Play("BunnyIdle");

        }
    }
    private void Flip()
    {
        isFacingRight = !isFacingRight;
        var localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }
}
