using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleColorChange : MonoBehaviour
{
    public  float TimeClock;
    public  Color CurrentGate;
    public int ritualCount;
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
        if(ritualCount == 1 || TimeClock >= 30)
        {
            if(R >0.93 && G > 0.75 && B >0.93)
            {
                R = R - Time.deltaTime / 300;
                G = G - Time.deltaTime / 100;
                B = B - Time.deltaTime / 300;
                Debug.Log(R);
                Debug.Log(G);
                Debug.Log(B);
            }
        }
        else if (ritualCount == 2 || TimeClock >= 120)
        {
            if (R > 0.85 && G > 0.6 && B > 0.85)
            {
                R = R - Time.deltaTime / 300;
                G = G - Time.deltaTime / 100;
                B = B - Time.deltaTime / 300;
                Debug.Log(R);
                Debug.Log(G);
                Debug.Log(B);
            }
        }
        else if (ritualCount == 3|| TimeClock >= 240)
        {
            if (R > 0.80 && G > 0.5 && B > 0.80)
            {
                R = R - Time.deltaTime / 300;
                G = G - Time.deltaTime / 100;
                B = B - Time.deltaTime / 300;
                Debug.Log(R);
                Debug.Log(G);
                Debug.Log(B);
            }
        }
       
    }
}
