using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public List<GameObject> ItemsInRange = new List<GameObject>();
    public Pickup Pickup;
    public ActivatedSpikeTrap Trap;
    public ItemSelector Inv;
  
    


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Item"))
        {
            Pickup = other.GetComponent<Pickup>();
        }
        if (other.CompareTag("Trap"))
        {
            Pickup = other.GetComponent<Pickup>();
            Trap = other.GetComponent<ActivatedSpikeTrap>();



        }
    }

    public void PickupItems()
    {
        if (Pickup.ItemInteractable)
        {
            Inv.allItems.Add(Pickup.InvItem);
            Destroy(Pickup.gameObject);
            
            if (Pickup.InvItem2 != null)
            {
                if (Trap.FullTrap)
                {
                    Inv.allItems.Add(Pickup.InvItem2);
                }
            }
            if (Pickup.InvItem3 != null)
            {
                Inv.allItems.Add(Pickup.InvItem3);

            }
            Inv.reLoadItems();
        }
    }
    
}
