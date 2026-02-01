using UnityEngine;

public class UIHandler : MonoBehaviour
{

    private int _currScore;
    private int _highScore;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameController.Instance.Player.score += updateScore; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void updateScore()
    {
        Debug.Log("Updated Score");
    }
}
