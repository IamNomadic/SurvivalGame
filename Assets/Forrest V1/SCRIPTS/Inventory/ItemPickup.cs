using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public List<GameObject> ItemsInRange = new List<GameObject>();
    public Pickup pickup;
    public SpikeTrap spikeTrap;
    public ItemSelector Inv;
  
    


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Item"))
        {


            //ItemsInRange.Add(other.gameObject);
            pickup = other.GetComponent<Pickup>();
           
            
                if(pickup.ItemInteractable)
                { 
                    pickup.pickup();
                    Debug.Log($"{other.gameObject.name} picked up!");
                }
        }
        if (other.CompareTag("Trap"))
        {
            spikeTrap = other.GetComponent<SpikeTrap>();
            
        }
    }

    public void PickupUsedTrap()
    {
        if (spikeTrap.UsedTrap)
        {
            
            Inv.allItems.Add(spikeTrap.TrapItem);

            Destroy(spikeTrap.gameObject);
            Inv.reLoadItems();
        }
    }
    public void EmptyFullTrap()
    {
        if (spikeTrap.FullTrap)
        {
            Inv.allItems.Add(spikeTrap.TrapItem);

            Destroy(spikeTrap.gameObject);
            Inv.reLoadItems();
        }
    }
}
