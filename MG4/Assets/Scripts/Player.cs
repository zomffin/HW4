using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float _upForce;
    [SerializeField] Rigidbody2D _rigidbody; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Hit Space");
            _rigidbody.linearVelocity = new Vector2(_rigidbody.linearVelocity.x, _upForce);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entered Trigger"); 
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Score"))
        {
            Debug.Log("Got a point"); 
        }
        Debug.Log("Exited Trigger"); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Hit an obstacle"); 
        }
    }
}
