using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GlobalScore.playerScore = 0;
    }
	
    public void OnBecameInvisible() {
        SceneManager.LoadScene("gameOverScene");
    }

	// Update is called once per frame
	void Update () {
		
	}
}
