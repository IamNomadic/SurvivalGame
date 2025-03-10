using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;



public class ItemPickup : MonoBehaviour
{
    public List<GameObject> ItemsInRange = new List<GameObject>();
    public Pickup Pickup;
    public ActivatedSpikeTrap Trap;
    public ItemSelector Inv;
    PlayerStats Stats;
    [SerializeField] AudioSource ItemPickupSound;
    public static event Action OnPlayerDamaged;


    private void Start()
    {
        Stats = GameObject.FindObjectOfType<PlayerStats>();
    }
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
        OnPlayerDamaged?.Invoke();
        if (Pickup.ItemInteractable)
        {
            Debug.Log("StatChange");
            if (Pickup.InvItem.Stats > 0)
            {
                if (Stats.CurrentHealth + Pickup.InvItem.Stats < Stats.MaxHealth+1)
                {
                    Stats.HealDamage(Pickup.InvItem.Stats);
                    
                }
                if (Stats.CurrentHunger + Pickup.InvItem.Stats < Stats.MaxHunger+1)
                {
                    Stats.GainHunger(Pickup.InvItem.Stats);
                    
                }
            }

            
            ItemPickupSound.Play();
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
        OnPlayerDamaged?.Invoke();
    }
    
}
