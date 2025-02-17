using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class RitualGenerator : MonoBehaviour
{
    public TextMeshPro timer;
    public List<GameObject> spawnPool;
    public GameObject quad;
    public TheWell theWell;
    public int ritualsCompleted;
    public bool ritualsDone;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        ritualsDone = false;
        spawnobjects();
    }
    private void FixedUpdate()
    {
        timer.text = (Math.Ceiling(time).ToString() + " Time Survived");
        time += Time.deltaTime;
        if (time < 14)
        {
            ritualsCompleted = 0;
        }
        else if (time < 45)
        {
            ritualsCompleted = 1;
        }
        else if (time < 120)
        {
            ritualsCompleted = 2;
        }
        else if (time < 200)
        {
            ritualsCompleted = 3;
        }
        else if (time < 230)
        {
            ritualsDone = true;
        }
    }
    public void spawnobjects()
    {

        int randomItem = 0;
        GameObject toSpawn;
        MeshCollider collider = quad.GetComponent<MeshCollider>();
        float screenX, screenY;
        Vector2 pos;
        for(int i = 0; i < 3; i++)
        {
            Debug.Log("ritual"+i);

            randomItem = UnityEngine.Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = UnityEngine.Random.Range(collider.bounds.min.x, collider.bounds.max.x);
            screenY = UnityEngine.Random.Range(collider.bounds.min.y, collider.bounds.max.y);
            pos = new Vector2(screenX, screenY);
            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
        }
    }
    private void destroyOjects()
    {
        foreach(GameObject o in GameObject.FindGameObjectsWithTag("Spawnable"))
        {
            Destroy(o);
        }
    }

}
