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
}
