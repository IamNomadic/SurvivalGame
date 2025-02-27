using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyAttack : MonoBehaviour
{
    public RitualGenerator RM;

    public PlayerStats PH;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (RM.ritualsCompleted >= 0)
        {
            if (collision.CompareTag("Player"))
            {
                PH.TakeDamage(1);
            }
        }
        if (RM.ritualsCompleted == 3)
        {
            if (collision.CompareTag("Player"))
            {
                PH.TakeDamage(1);

            }
        }
    }
}
