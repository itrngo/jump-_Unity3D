using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superRotation : MonoBehaviour {

    
    public GameObject Scene;
	void Start () {
        Scene = GameObject.Find("sceneHolder");
	}
	
	// Update is called once per frame
	void Update () {
        //InvokeRepeating(rotate(), 3);
        //InvokeRepeating(rotateBack(), 10);

    }
    void rotate()
    {
        //Scene.Rotate(new Vector3(0, 0, -90));
    }
    void rotateBack()
    {
        //Scene.Rotate(new Vector3(0, 0, 90));
    }
}
