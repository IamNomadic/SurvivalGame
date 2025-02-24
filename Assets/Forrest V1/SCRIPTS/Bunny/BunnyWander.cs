using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyWander : MonoBehaviour
{
    public GameObject PC;
    public SmellZone smellZone;
    public RitualGenerator RM;
    public Rigidbody2D rb;
    Vector2 direction;
    Vector2 zero = new Vector2(2,2);
    float distance;
    float speed;
    bool hit;
    bool targetLock;
    private void Start()
    {

        if(RM.ritualsCompleted >= 3)
        {
            this.transform.localScale = new Vector3(0.6f, 0.6f, 1);
        }
    }
    private void Update()
    {
        distance = ((float)Math.Sqrt((gameObject.transform.position.x  - PC.transform.position.x)*(gameObject.transform.position.x - PC.transform.position.x) + (gameObject.transform.position.y - PC.transform.position.y) * (gameObject.transform.position.y - PC.transform.position.y)));
        Vector2 direction = transform.position - PC.transform.position;
        direction.Normalize();
        
        #region Phase 1
        if (RM.ritualsCompleted == 0)
        {
            if (distance > 0.9 &&!hit)
            {
                speed = 0.7f;
            }
            else if (distance < 0.9 && !hit)
            {
                speed = 1.5f;
            }
            if (smellZone.targetLock)
            {
                rb.velocity = direction * speed;
            }
            else if (!smellZone.targetLock)
            {
                rb.velocity = rb.velocity / zero;
            }
        }
        #endregion
        #region Phase 2
        if (RM.ritualsCompleted == 1)
        {
            if (distance > 1.0 && !hit)
            {
                speed = 0.7f;
            }
            else if (distance > 0.4 && !hit)
            {
                speed = -0.5f;
            }
            else if (distance > 0.1 && !hit)
            {
                speed = -1.5f;
            }
            else if (distance < 0.1)
            {
                speed = 1.5f;
                hit = true;
                StartCoroutine(HitPlayer());
            }
            if (smellZone.targetLock)
            {
                rb.velocity = direction * speed;
            }
            else if (!smellZone.targetLock)
            {
                rb.velocity = rb.velocity / zero;
            }
        }
        #endregion
        #region Phase 3
        if (RM.ritualsCompleted >= 2)
        {
            if (distance > 1.4 && !hit)
            {
                speed = -0.5f;
            }
            else if (distance > 0.4 && !hit)
            {
                speed = -0.7f;
            }
            else if (distance > 0.1 && !hit)
            {
                speed = -1.5f;
            }
            else if (distance < 0.1)
            {
                speed = 1.5f;
                hit = true;
                StartCoroutine(HitPlayer());
            }
            if (smellZone.targetLock)
            {
                rb.velocity = direction * speed;
            }
            else if (!smellZone.targetLock)
            {
                rb.velocity = rb.velocity / zero;
            }
        }
        #endregion
        #region Phase 4
        if (RM.ritualsCompleted >= 3)
        {
            rb.velocity = direction*-0.2f;
            if (distance > 1.4 && !hit)
            {
                speed = -0.7f;
            }
            else if (distance > 1 && !hit)
            {
                speed = -0.9f;
            }
            else if (distance > 0.4 && !hit)
            {
                speed = -1.3f;
            }
            else if (distance < 0.1 && !hit)
            {
                speed = -1.5f;
            }
            else if (distance < 0.1)
            {
                speed = 1.5f;
                hit = true;
                StartCoroutine(HitPlayer());
            }
            if (smellZone.targetLock)
            {
                rb.velocity = direction * speed;
            }
            else if (!smellZone.targetLock)
            {
                rb.velocity = rb.velocity / zero;
            }
        }
        #endregion
        IEnumerator HitPlayer()
        {
            yield return new WaitForSeconds(1);
            hit = false;
        }
    }
    
   
}
