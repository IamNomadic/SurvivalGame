using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    protected bool ItemInteractable;
    public ItemSelector inv;
    public GameObject itemSelector;
    private void Start()
    {
        inv = itemSelector.GetComponent<ItemSelector>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PlayerMovement>(out PlayerMovement playerMovement))
        {
            if (playerMovement != null)
            {
                ItemInteractable = true;
            }
        }
        Debug.Log(ItemInteractable);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<PlayerMovement>(out PlayerMovement playerMovement))
        {
            if (playerMovement != null)
            {
                ItemInteractable = false;
            }
        }
        Debug.Log(ItemInteractable);


    }
}
