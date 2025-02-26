using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    public float TotalTime;// Total Game Time 
    float LastRitualTime;// Time Since Last Ritual
    float LastRitualTimeGate;//Time To cap Last Ritual Time 
    public int RitualsCompleted;//Number Of Rituals Completed
    bool TempCap;
    int GameBaseDifficultyCap;//Set By Rituals 
    float GameModifierDifficulty;//Set by Time Since Last Ritual
    public float CurrentDifficulty;//Actual Difficiulty Value Used By Game
    void Start()
    {

    }
    void FixedUpdate ()
    {
        TotalTime = Time.deltaTime + TotalTime;
        //Debug.Log(LastRitualTime);

        if(LastRitualTime<=LastRitualTimeGate && TempCap == false)
        {
            GameModifierDifficulty = (LastRitualTime/LastRitualTimeGate);
            Debug.Log("Setting Game GameModifierDifficulty");
            CalculateGameDifficulty();
            LastRitualTime = Time.deltaTime + LastRitualTime;
        }
        else if(LastRitualTime>LastRitualTimeGate)
        {
            TempCap = true;
            LastRitualTime = 0;
        }

        
        

    }
    void CalculateGameDifficulty()
    {
            CurrentDifficulty = (GameBaseDifficultyCap+GameModifierDifficulty);
            Debug.Log(CurrentDifficulty);
    }
    
    void ChangeGameState()
    {
        GameBaseDifficultyCap = RitualsCompleted;
        

        
    }





}
