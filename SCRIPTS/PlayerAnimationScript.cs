using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationScript : MonoBehaviour
{
    public bool Animated;
    [HideInInspector] public string CurrentTorso;
    [HideInInspector] public string CurrentLeg;
    [HideInInspector] public string CurrentFeet;
    [HideInInspector] public string CurrentHead;
    [HideInInspector] public string CurrentShoulder;
    [HideInInspector] public string CurrentGloves;
    [HideInInspector] public string CurrentCap;
    public SpriteRenderer SRC;

    public Animator AF;
    public Animator AL;
    public Animator AT;
    public Animator AS;
    public Animator AH;
    public Animator AG;
    public Animator AC;

    // Start is called before the first frame update
    void Start()
    {
        Animated = true;
        CurrentTorso = "Torso";
        CurrentHead = "Head";
        CurrentFeet = "Feet";
        CurrentShoulder = "Shoulders";
        CurrentLeg = "Legs";
        CurrentGloves = "Gloves";
        CurrentCap = "Hair";


    }

    // Update is called once per frame
    void Update()
    {
        if (Animated)
        {
            AF.Play(CurrentFeet);
            AL.Play(CurrentLeg);
            AT.Play(CurrentTorso);
            AS.Play(CurrentShoulder);
            AH.Play(CurrentHead);
            AG.Play(CurrentGloves);
            AC.Play(CurrentCap);
        }
            
    }
    IEnumerator Refresh()
    {
        
        AF.Play(0);
        AL.Play(0);
        AT.Play(0);
        AS.Play(0);
        AH.Play(0);
        AG.Play(0);
        AC.Play(0);
        yield return null;
    }
    public void Armor1()
    {

        CurrentCap = "Cap";
        StartCoroutine(Refresh());
        
    }

}
