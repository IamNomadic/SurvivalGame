using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyAnimation : MonoBehaviour
{
    public SpriteRenderer SR;
    public Rigidbody2D BunnyRB;
    public Animator BunnyAnimator;
    private void Update()
    {
        
        if (BunnyRB.velocity.x >0.1|| BunnyRB.velocity.x < -0.1)
        {
            BunnyAnimator.Play("BunnyWalk");
            Debug.Log("running");
        }
        else
        {
            BunnyAnimator.Play("BunnyIdle");
            Debug.Log("shill");

        }
    }
}
