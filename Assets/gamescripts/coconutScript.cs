using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coconutScript : MonoBehaviour {
    public float fallSpeed = 0.5f;
    public Component coconut;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float xPosition = Random.Range(-5, 10);
        if (Random.Range(1, 500) == 42)
        {
            Instantiate(coconut, new Vector2(xPosition, 25), Quaternion.identity);
        }
        transform.Translate(Vector2.down * fallSpeed * Time.deltaTime, Space.World);
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("gameOverScene");
        }
    }
}
