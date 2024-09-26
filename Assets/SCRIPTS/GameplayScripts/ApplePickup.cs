using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePickup : Interactable
{
    public ItemSO appleInvItem;   
    public void pickup()
    {
        if (ItemInteractable)
        {
            inv.allItems.Add(appleInvItem);
            Destroy(gameObject);
            inv.reLoadItems();
        }
    }
}
