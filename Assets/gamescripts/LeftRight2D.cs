using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRight2D : MonoBehaviour {
    bool rotated = false;
    const float MINYDIST = 2.0f;
    const float MAXYDIST = 2.6f;
    const float MINXDIST = -4.5f;
    const float MAXXDIST = 4.5f;

    public GameObject[] itemsToSpawn;
    public GameObject player;
    public GameObject[] walls;
    public GameObject[] copiedWalls;
    bool hasSpawned = false;
    bool spawnedSide = false;

    float platformSpeed = 2f;
    bool endPoint;
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        walls = GameObject.FindGameObjectsWithTag("wall");
    }
	
	// Update is called once per frame
	void Update () {
		if(endPoint)
        {
            transform.position += Vector3.right * platformSpeed * Time.deltaTime;
        }
        else
        {
            transform.position -= Vector3.right * platformSpeed * Time.deltaTime;
        }

        if(transform.position.x >=3f)
        {
            endPoint = false;
        }
        if(transform.position.x<=-3f)
        {
            endPoint = true;
        }


	}


}
