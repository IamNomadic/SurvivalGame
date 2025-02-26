using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : Interactable
{
    public ItemSO InvItem;
    public void Start()
    {
        
            inv = GameObject.FindObjectOfType<ItemSelector>();
           PH = GameObject.FindObjectOfType<PlayerHealth>();
    }
    public void pickup()
    {
        if (ItemInteractable)
        {
            inv.allItems.Add(InvItem);
            Destroy(this.gameObject);
            inv.reLoadItems();
            Debug.Log("pickup");
            
        }
    }
}
