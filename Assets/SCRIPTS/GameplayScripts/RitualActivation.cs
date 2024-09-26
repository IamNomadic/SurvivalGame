using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RitualActivation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Ritual collider");

        if (collision.TryGetComponent<DeadBunny>(out DeadBunny deadbunny))
        {
            if (deadbunny != null)
            {
                Debug.Log("Ritual Started!");
            }
        }
    }
}
