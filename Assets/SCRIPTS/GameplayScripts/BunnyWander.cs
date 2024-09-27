using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyWander : MonoBehaviour
{
    public GameObject PC;
    bool targetLock;
    public Rigidbody2D rb;
    Vector2 direction;
    float distance;
    Vector2 zero = new Vector2(2,2);
    float speed;
    private void Update()
    {
        distance = ((float)Math.Sqrt((gameObject.transform.position.x  - PC.transform.position.x)*(gameObject.transform.position.x - PC.transform.position.x) + (gameObject.transform.position.y - PC.transform.position.y) * (gameObject.transform.position.y - PC.transform.position.y)));
        Vector2 direction = transform.position - PC.transform.position;
        direction.Normalize();
        if (distance > 0.9)
        {
            speed = 1;
        }
        else if (distance < 0.9)
        {
            speed = 2;
        }
        if (targetLock)
        {
            
    

            
            rb.velocity =  direction * speed;
                        
        }
        else if (!targetLock)
        {
            rb.velocity = rb.velocity / zero;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            targetLock = true;
            
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            targetLock = false;
        }
    }
   
}
