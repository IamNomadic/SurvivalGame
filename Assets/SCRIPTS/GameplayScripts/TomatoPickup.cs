using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoPickup : Interactable
{
    public ItemSO TomatoInvItem;
    public void pickup()
    {
        if (ItemInteractable)
        {
            inv.allItems.Add(TomatoInvItem);
            Destroy(gameObject);
            inv.reLoadItems();
        }
    }
}
