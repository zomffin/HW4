using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float _upForce;
    [SerializeField] Rigidbody2D _rigidbody;
    [SerializeField] Vector2 _startPosition; 

    public delegate void scoreDelegate(); 
    public event scoreDelegate score;

    public delegate void endDelegate();
    public event endDelegate end;

    private bool _gameOver; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameController.Instance.restart += reset; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && !_gameOver)
        {
            _rigidbody.linearVelocity = new Vector2(_rigidbody.linearVelocity.x, _upForce);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Score"))
        {
            score?.Invoke(); 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Obstacle") || collision.gameObject.CompareTag("Ground"))
        {
            end?.Invoke();
            _gameOver = true; 
        }
    }

    private void reset()
    {
        this.transform.position = _startPosition;
        _gameOver = false; 
    }
}
