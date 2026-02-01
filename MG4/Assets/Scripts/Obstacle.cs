using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] float _speed;
    //[SerializeField] 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector2.left * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Obstacle hit trigger"); 
        if (other.CompareTag("Finish"))
        {
            Destroy(this.gameObject); 
        }
    }
}
