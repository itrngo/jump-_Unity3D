using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

    public GameObject[] itemsToSpawn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Spawn()
    {
        Instantiate(
            itemsToSpawn[Random.Range(0, itemsToSpawn.Length)],
            new Vector3(Random.Range(0, 11), this.transform.position.y),
            Quaternion.identity
            );
    }
}
