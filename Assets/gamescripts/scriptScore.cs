using UnityEngine;

public static class GlobalScore {
    public static float playerScore = 0;
}

public class scriptScore : MonoBehaviour
{
    
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GlobalScore.playerScore += Time.deltaTime;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 30), "score: " + (int)(GlobalScore.playerScore * 100));
    }
}