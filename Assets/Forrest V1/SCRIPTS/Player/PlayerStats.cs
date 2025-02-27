using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public int CurrentStamina;
    public int MaxStamina;
    public int MaxHealth;
    public int CurrentHealth;
 

    public bool dead;

    private void Start()
    {


    }

    // Update is called once per frame
    private void Update()
    {
        if (CurrentHealth >= MaxHealth) CurrentHealth = MaxHealth;
       
    }

    public static event Action OnPlayerDamaged;

    private IEnumerator LevelReset()
    {
        yield return new WaitForSeconds(0.5f);
        dead = false;
        SceneManager.LoadScene("Title");
    }

    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
      
       
        OnPlayerDamaged?.Invoke();
        if (CurrentHealth <= 0)
        {
            StartCoroutine("LevelReset");
            Debug.Log("you are dead");


            dead = true;
        }
    }
    public void HealDamage(int Health)
    {
        CurrentHealth += Health;


        OnPlayerDamaged?.Invoke();
        if (CurrentHealth <= 0)
        {
            StartCoroutine("LevelReset");
            Debug.Log("you are dead");


            dead = true;
        }
    }
    public void OnCollisionEnter2D (Collision2D DeathBox)
    {
       
     
    }
}