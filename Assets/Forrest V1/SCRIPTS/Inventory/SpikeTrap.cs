using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrap : MonoBehaviour
{
    public ItemSO InvItem;
    public ItemSO TrapItem;
    public bool FullTrap;
    public bool StoneTrap;
    bool TrapUsed;
    public BunnyHealth Bunny;
    public Collider2D Killbox;
    public GameObject DeadBunny;
    public Transform TrapLoc;
    public Sprite UsedTrap;
    public SpriteRenderer SR;

    private void Start()
    {
        FullTrap = false;
       
    }
    private void FixedUpdate()
    {
        if(TrapUsed)
        {
            SR.sprite = UsedTrap;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Enemy")&&!FullTrap)
        {
            Bunny = collision.GetComponent<BunnyHealth>();
            TrapUsed = true;
            if (Bunny.BunnyHP == 1)
            {
                Instantiate(DeadBunny,TrapLoc);
                if (!StoneTrap)
                {
                    FullTrap = true;
                }
            }
            if (Bunny.BunnyHP == 2 && StoneTrap)
            {
                Instantiate(DeadBunny, TrapLoc);
                FullTrap = true;

            }
            Bunny.TakeDMG(1);
            if (StoneTrap)
            {
                Bunny.TakeDMG(1);
                Debug.Log("2dmg");
            }


        }
    }

}
