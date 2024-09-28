using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public List<GameObject> ItemsInRange = new List<GameObject>();
    public Pickup pickup;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Item"))
        {


            ItemsInRange.Add(other.gameObject);
            pickup = other.GetComponent<Pickup>();

            if (other.GetComponent<Pickup>() is Pickup)
            {
                
                pickup.pickup();
                Debug.Log($"{other.gameObject.name} picked up!");
            }
           
        }
    }
    /*public void PickupWithinRange()
    {
        pickup.pickup();
    }
    */
}
