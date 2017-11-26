using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

    public GameObject player;
    public float speed = 1.0f;
    public float slowrate = 0.35f;
    public const float MAXSPEED = 8.0f;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
                if(speed < MAXSPEED)
                {
                    speed += (Time.deltaTime*slowrate);
                }
                transform.position = transform.position + new Vector3(0, Time.deltaTime * speed, 0);             
	}
}
