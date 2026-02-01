using UnityEngine;

public class audioHandler : MonoBehaviour
{
    [SerializeField] AudioClip _point;
    [SerializeField] AudioClip _end;
    [SerializeField] AudioSource _source;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameController.Instance.Player.score += scorePoint;
        GameController.Instance.Player.end += gameOver; 
    }

    void scorePoint()
    {
        _source.resource = _point;
        _source.Play();
    }

    void gameOver()
    {
        _source.resource = _end;
        _source.Play(); 
    }
    
}
