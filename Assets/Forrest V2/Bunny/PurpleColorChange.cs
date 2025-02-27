using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleColorChange : MonoBehaviour
{
    public  float TimeClock;
    public  Color CurrentGate;
    public RitualGenerator RM;

    float R;
    float G;
    float B;
    float A;
    [SerializeField] public SpriteRenderer SR;
    // Start is called before the first frame update
    void Start()
    {
        R = 1;
        G = 1;
        B = 1;
        A = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TimeClock = TimeClock + Time.deltaTime;
        SR.color = new Color(R, G, B, A);
        if(RM.ritualsCompleted == 1)
        {
            if(R >0.93 && G > 0.75 && B >0.93)
            {
                R = R - Time.deltaTime / 300;
                G = G - Time.deltaTime / 100;
                B = B - Time.deltaTime / 300;

            }
        }
        else if (RM.ritualsCompleted == 2)
        {
            if (R > 0.85 && G > 0.6 && B > 0.85)
            {
                R = R - Time.deltaTime / 300;
                G = G - Time.deltaTime / 100;
                B = B - Time.deltaTime / 300;

            }
        }
        else if (RM.ritualsCompleted == 3)
        {
            if (R > 0.80 && G > 0.5 && B > 0.80)
            {
                R = R - Time.deltaTime / 300;
                G = G - Time.deltaTime / 100;
                B = B - Time.deltaTime / 300;
                Debug.Log("Called");
            }
        }
       
    }
}
