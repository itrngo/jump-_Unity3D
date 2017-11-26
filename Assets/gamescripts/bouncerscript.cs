using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncerscript : MonoBehaviour {

    bool checker = true;
    const float MINYDIST = 2.0f;
    const float MAXYDIST = 2.3f;
    const float MINXDIST = -4.5f;
    const float MAXXDIST = 4.0f;
    private float nextActionTime = 0.0f;
    public float period = 2.0f;
    public GameObject cameraMain;
    public GameObject[] itemsToSpawn;
    public GameObject player;
    public GameObject[] walls;
    public GameObject[] copiedWalls;
    bool hasSpawned = false;
    bool spawnedSide = false;

    // Use this for initialization
    void Start () {
        cameraMain = GameObject.FindGameObjectWithTag("MainCamera");
        player = GameObject.FindGameObjectWithTag("Player");
        walls = GameObject.FindGameObjectsWithTag("wall");
      
    }
	
	// Update is called once per frame


    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("i am here");
        if (coll.gameObject.tag == "Player")
        {
            
            if (!hasSpawned)
            {
                
                Spawn();

               // extendWalls();
                hasSpawned = true;
            }

        }
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("i am here");
    }

    void Spawn()
    {
        if (player.transform.position.x > 9)
        {
            Instantiate(
                        itemsToSpawn[Random.Range(0, itemsToSpawn.Length)],
                        new Vector3(Random.Range(player.transform.position.x + MAXXDIST, player.transform.position.x - MAXXDIST * 0.7f), Random.Range(player.transform.position.y + MINYDIST, player.transform.position.y + MAXYDIST)),
                        Quaternion.identity
                        );
        }
        else if (player.transform.position.x < -1)
        {
            Instantiate(
            itemsToSpawn[Random.Range(0, itemsToSpawn.Length)],
            new Vector3(Random.Range(player.transform.position.x + 6, player.transform.position.x + MAXXDIST * 1.2f), Random.Range(player.transform.position.y + MINYDIST, player.transform.position.y + MAXYDIST)),
            Quaternion.identity
            );
        }
        else
        {
            Instantiate(
                    itemsToSpawn[Random.Range(0, itemsToSpawn.Length)],
                    new Vector3(Random.Range(MINXDIST, MAXXDIST), Random.Range(player.transform.position.y + MINYDIST, player.transform.position.y + MAXYDIST)),
                    Quaternion.identity
    );
        }
    }
    void extendWalls()
    {
        Vector2 pos = walls[0].transform.position;
        Instantiate(walls[0]);
        walls[0].transform.position = pos + new Vector2(0.0f, 5.0f);

        Vector2 pos2 = walls[1].transform.position;
        Instantiate(walls[1]);
        walls[1].transform.position = pos2 + new Vector2(0.0f, 5.0f);
    }
}
