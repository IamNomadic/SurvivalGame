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
        Debug.Log(RG.ritualsDone);


        if (collision.CompareTag("Player")&&RG.ritualsDone)
        {
            Debug.Log("post");

            SceneManager.LoadScene("Title");
        }
    }
}
