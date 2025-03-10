using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RitualActivation : MonoBehaviour
{
    GameTimer GT;
    bool RitualComplete;
    // Start is called before the first frame update
    void Start()
    {
        GT = GameObject.FindObjectOfType<GameTimer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Item") && !RitualComplete)
        {
            GT.RitualsCompleted++;
            RitualComplete = true;
        }
        

        
    }
}
