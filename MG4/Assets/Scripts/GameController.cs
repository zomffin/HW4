using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }
    public Player Player { get; private set; }


    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
            return; 
        }

        Instance = this; 

        Player = GameObject.FindWithTag("Player").GetComponent<Player>();

        Player.end += endGame;

    }
    
    void endGame()
    {
        Debug.Log("Game ended");
        Time.timeScale = 0f; 


    }
    
}
