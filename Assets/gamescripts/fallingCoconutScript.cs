using UnityEngine;
using UnityEngine.SceneManagement;

public class fallingCoconutScript : MonoBehaviour {

    public float fallSpeed = 0.5f;
    public Component coconut;

    private void Start() {
    }

    void Update() {
        float xPosition = Random.Range(-5, 10);
        if (Random.Range(1,500) == 42) {
            Instantiate(coconut, new Vector3(xPosition, 25, 0), Quaternion.identity);
        }
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Player") {
            SceneManager.LoadScene("gameOverScene");
        }
    }

}