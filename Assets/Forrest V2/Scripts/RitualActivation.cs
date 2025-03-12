using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RitualActivation : MonoBehaviour
{
    GameTimer GT;
    BunnyGenerator BG;
    PlayerStats PS;
    bool RitualComplete;
    [SerializeField] int AdditionalBunniesToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        GT = GameObject.FindObjectOfType<GameTimer>();
        BG = GameObject.FindObjectOfType<BunnyGenerator>();
        PS = GameObject.FindObjectOfType<PlayerStats>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item") && !RitualComplete)
        {
            CompleteRitual();
        }
        

        
    }
    void CompleteRitual()
    {
        GT.RitualsCompleted++;
        RitualComplete = true;
        int i = 0;
        while ( i < AdditionalBunniesToSpawn)
        {
            i++;
            BG.BunniesToSpawn++;
            BG.SpawnCooldown = 0;
            PS.RefreshHud();
        }
    }
}
