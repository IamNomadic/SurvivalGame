using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool ItemInteractable;
    public PlayerHealth PH;
    public ItemSelector inv;
    public GameObject itemSelector;
    private void Start()
    {
        inv = GameObject.FindObjectOfType<ItemSelector>();
        Debug.Log("Called");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<ItemPickup>(out ItemPickup playerMovement))
        {
            if (playerMovement != null)
            {
                ItemInteractable = true;
            }
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<ItemPickup>(out ItemPickup playerMovement))
        {
            if (playerMovement != null)
            {
                ItemInteractable = false;
            }
        }


    }
}
