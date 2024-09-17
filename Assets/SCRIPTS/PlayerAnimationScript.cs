using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationScript : MonoBehaviour
{
    public PlayerMovement PM;
    public bool Called;
    public bool Animated;
    [HideInInspector] public string CurrentTorso;
    [HideInInspector] public string CurrentLeg;
    [HideInInspector] public string CurrentFeet;
    [HideInInspector] public string CurrentHead;
    [HideInInspector] public string CurrentShoulders;
    [HideInInspector] public string CurrentHands;
    [HideInInspector] public string CurrentHair;
   
    public SpriteRenderer SRC;

    public Animator AFeet;
    public Animator ALegs;
    public Animator ATorso;
    public Animator AShoulders;
    public Animator AHead;
    public Animator AHands;
    public Animator AHair;

    // Start is called before the first frame update
    void Start()
    {
        Animated = true;
        CurrentTorso = "Torso";
        CurrentHead = "Head";
        CurrentFeet = "Feet";
        CurrentShoulders = "Shoulders";
        CurrentLeg = "Legs";
        CurrentHands = "Gloves";
        CurrentHair = "Hair";


    }

    // Update is called once per frame
    void Update()
    {
        if (Animated && PM.horizontal < 0 && PM.vertical < 0|| Animated && PM.horizontal > 0 && PM.vertical < 0)
        {

            AFeet.Play("FeetRunLeftDown");
            ALegs.Play("LegsRunLeftUp");
            ATorso.Play("TorsoRunLeftUp");
            AShoulders.Play("ShouldersRunLeftDown");
            AHead.Play("HeadRunLeftDown");
            AHands.Play("HandsRunLeftUp");
            AHair.Play("HairRunLeftDown");
        }
        else if (Animated && PM.horizontal < 0 && PM.vertical > 0 || Animated && PM.horizontal > 0 && PM.vertical > 0)
        {

     
            AFeet.Play("FeetRunLeftUp");
            ALegs.Play("LegsRunLeftDown");
            ATorso.Play("TorsoRunLeftUp");
            AShoulders.Play("ShouldersRunLeftUp");
            AHead.Play("HeadRunLeftUp");
            AHands.Play("HandsRunLeftUp");
            AHair.Play("HairRunLeftUp");
        }
        else if (Animated && PM.horizontal < 0 || Animated && PM.horizontal > 0)
        {

         
            AFeet.Play("FeetRunLeft");
            ALegs.Play("LegsRunLeft");
            ATorso.Play("TorsoRunLeft");
            AShoulders.Play("ShouldersRunLeft");
            AHead.Play("HeadRunLeft");
            AHands.Play("HandsRunLeft");
            AHair.Play("HairRunLeft");
        }
        else if (Animated && PM.vertical < 0 )
        {
          

            AFeet.Play("FeetRunDown");
            ALegs.Play("LegsRunDown");
            ATorso.Play("TorsoRunDown");
            AShoulders.Play("ShouldersRunDown");
            AHead.Play("HeadRunDown");
            AHands.Play("HandsRunDown");
            AHair.Play("HairRunDown");
        }
        else if (Animated && PM.vertical > 0)
        {
           
            AFeet.Play("FeetRunUp");
            ALegs.Play("LegsRunUp");
            ATorso.Play("TorsoRunUp");
            AShoulders.Play("ShouldersRunUp");
            AHead.Play("HeadRunUp");
            AHands.Play("HandsRunUp");
            AHair.Play("HairRunUp");
        }
        else if (Animated)
        {
            
            AFeet.Play("FeetIdleDown");
            ALegs.Play("LegsIdleDown");
            ATorso.Play("TorsoIdleDown");
            AShoulders.Play("ShoulderIdleDown");
            AHead.Play("HeadIdleDown");
            AHands.Play("HandsIdleDown");
            AHair.Play("HairIdleDown");
        }        
    }
    IEnumerator Refresh()
    {
        
        AFeet.Play(0);
        ALegs.Play(0);
        ATorso.Play(0);
        AShoulders.Play(0);
        AHead.Play(0);
        AHands.Play(0);
        AHair.Play(0);
        yield return null;
    }
    public void Armor1()
    {

        StartCoroutine(Refresh());
        
    }

}
