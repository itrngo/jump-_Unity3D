using UnityEngine;
using UnityEngine.SceneManagement;

public class uimanagerScript : MonoBehaviour {

    GameObject[] pauseObjects;

    // Use this for initialization
    void Start() {
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("showOnPause");
        hidePaused();
    }

    // Update is called once per frame
    void Update() {

        //uses the escape button to pause and unpause the game
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(Time.timeScale == 1) {
                Time.timeScale = 0;
                showPaused();
            } else if(Time.timeScale == 0) {
                Debug.Log("high");
                Time.timeScale = 1;
                hidePaused();
            }
        }
    }
    
    //quit the game
    public void quit() {
        Application.Quit();
    }

    //go to main menu
    public void mainMenu() {
        SceneManager.LoadScene("menuScene");
    }

    //Reloads the Level
    public void Reload() {
        SceneManager.LoadScene("gameScene");
    }

    //controls the pausing of the scene
    public void pauseControl() {
        if(Time.timeScale == 1) {
            Time.timeScale = 0;
            showPaused();
        } else if(Time.timeScale == 0) {
            Time.timeScale = 1;
            hidePaused();
        }
    }

    //shows objects with ShowOnPause tag
    public void showPaused() {
        foreach(GameObject g in pauseObjects) {
            g.SetActive(true);
        }
    }

    //hides objects with ShowOnPause tag
    public void hidePaused() {
        foreach(GameObject g in pauseObjects) {
            g.SetActive(false);
        }
    }

    //loads inputted level
    public void LoadLevel(string level) {
        Application.LoadLevel(level);
    }
}
