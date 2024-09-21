using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyWander : MonoBehaviour
{
    public GameObject PC;
    bool targetLock;
    public Rigidbody2D rb;
    Vector2 direction;
    private void Update()
    {
        

        Vector2 direction = transform.position - PC.transform.position;
        direction.Normalize();
        if (targetLock)
        {
            Debug.Log("im trying to run!!");
            Debug.Log(direction * -1);

            Debug.Log(targetLock);
            rb.velocity =  1 * direction;
                        
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            targetLock = true;
            Debug.Log("i smell you");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            targetLock = false;
            Debug.Log("i lost you");
        }
    }
   
}
