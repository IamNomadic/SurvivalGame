using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class RitualGenerator : MonoBehaviour
{
    //public TextMeshPro timer;
    public List<GameObject> spawnPool;
    public GameObject quad;
    public TheWell theWell;
    public int ritualsCompleted;
    public bool ritualsDone;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        ritualsDone = false;
        spawnobjects();
    }
    private void FixedUpdate()
    {
        
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
