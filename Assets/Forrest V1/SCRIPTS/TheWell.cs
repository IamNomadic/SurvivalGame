using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TheWell : MonoBehaviour
{
    public RitualGenerator RG;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("pre");
        Debug.Log(RG.RitualsDone);


        if (collision.CompareTag("Player")&&RG.RitualsDone)
        {
            Debug.Log("post");

            SceneManager.LoadScene("Title");
        }
    }
}
