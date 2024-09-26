using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.TryGetComponent<ApplePickup>(out ApplePickup apple))    
        {
            apple.pickup();
        }
    }
        
}
