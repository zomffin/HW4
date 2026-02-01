using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }
    public Player Player { get; private set; }

    public delegate void restartDelegate();
    public event restartDelegate restart;

    [SerializeField] GameObject _obstacle; 
    [SerializeField] float _timer;
    [SerializeField] float _maxHeight;
    [SerializeField] float _minHeight; 
    private float _currTime;
    private bool _gameEnded = false; 

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

    private void Start()
    {
        spawnObstacle(); 
    }

    private void Update()
    {
        _currTime += Time.deltaTime; 
        if (_currTime >= _timer && !_gameEnded)
        {
            spawnObstacle(); 
            _currTime = 0; 
        }
    }


    void endGame()
    {
        _gameEnded = true;
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle"); 
        foreach (GameObject obstacle in obstacles)
        {
            Destroy(obstacle);
        }
    }

    public void restartGame()
    {
        Debug.Log("Game restarted"); 
        restart?.Invoke();
        _gameEnded = false; 
        _currTime = 0;
        spawnObstacle(); 
    }

    private void spawnObstacle()
    {
        GameObject obstacle = Instantiate(_obstacle);
        obstacle.transform.position = new Vector2(this.transform.position.x, Random.Range(_minHeight, _maxHeight));
    }
    
}
