using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public AudioSource DeathSound;
    public PlayerMovement playerMovement;
    public int maxHealth;
    public int currentHealth;
 

    public bool dead;
    private Animator animator;
    private float healthToBe;

    private void Start()
    {
        animator = GetComponent<Animator>();
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
        Debug.Log("called");
        dead = false;
        SceneManager.LoadScene("StartScreen");
    }

    public void TakeDamage(int damage, Vector2 direction)
    {
        currentHealth -= damage;
        Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
      
        rb.velocity = new Vector2(direction.x * 10000, direction.y * 10000);
        OnPlayerDamaged?.Invoke();
        if (currentHealth <= 0)
        {
            StartCoroutine("LevelReset");
            Debug.Log("you are dead");
            DeathSound.Play();
            animator.Play("Hit");
            dead = true;
        }
    }
    public void OnCollisionEnter2D (Collision2D DeathBox)
    {
       
       if (DeathBox.gameObject.CompareTag("DeathBox"))
       {
                Debug.Log("dead");

        StartCoroutine("LevelReset");
       }
    }
}