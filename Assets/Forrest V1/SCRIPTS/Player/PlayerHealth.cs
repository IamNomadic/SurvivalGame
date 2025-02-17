using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public int maxHealth;
    public int currentHealth;
 

    public bool dead;

    private void Start()
    {

        currentHealth = maxHealth;
    }

    // Update is called once per frame
    private void Update()
    {
        if (currentHealth >= maxHealth) currentHealth = maxHealth;
       
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
        currentHealth -= damage;
      
       
        OnPlayerDamaged?.Invoke();
        if (currentHealth <= 0)
        {
            StartCoroutine("LevelReset");
            Debug.Log("you are dead");


            dead = true;
        }
    }
    public void HealDamage(int Health)
    {
        currentHealth += Health;


        OnPlayerDamaged?.Invoke();
        if (currentHealth <= 0)
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