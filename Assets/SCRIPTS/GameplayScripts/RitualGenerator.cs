using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RitualGenerator : MonoBehaviour
{
    public List<GameObject> spawnPool;
    public GameObject quad;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        spawnobjects();
    }
    public void spawnobjects()
    {
        Debug.Log("spawnobjects");

        int randomItem = 0;
        GameObject toSpawn;
        MeshCollider collider = quad.GetComponent<MeshCollider>();
        float screenX, screenY;
        Vector2 pos;
        for(int i = 0; i < 3; i++)
        {
            Debug.Log("ritualobjects");

            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = Random.Range(collider.bounds.min.x, collider.bounds.max.x);
            screenY = Random.Range(collider.bounds.min.y, collider.bounds.max.y);
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
