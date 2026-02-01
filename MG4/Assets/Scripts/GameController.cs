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

        Player = GameObject.FindWithTag("Player").GetComponent<Player>();

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
