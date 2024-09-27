using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public List<GameObject> ItemsInRange = new List<GameObject>();
    ApplePickup AP;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Item"))
        {
            Debug.Log("Tagcheck");
            ApplePickup AP = other.GetComponent<ApplePickup>();
            AP.pickup();
        }
        
      
    }
        
}
