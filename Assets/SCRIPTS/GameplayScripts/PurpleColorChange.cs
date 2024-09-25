using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleColorChange : MonoBehaviour
{
    public  float TimeClock;
    public  Color FirstGate;
    public Color SecondGate;
    public  Color ThirdGate;
    public  Color CurrentGate;
    [SerializeField] public SpriteRenderer SR;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TimeClock = Time.deltaTime + TimeClock;
        if (TimeClock == 5)
        {
            SR.material.color = FirstGate;
        }
        if (TimeClock == 7)
        {
            SR.material.color = SecondGate;
        }
        if (TimeClock == 10)
        {
            SR.material.color = ThirdGate;
        }




    }
}
