using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI _scoreText;
    [SerializeField] TextMeshProUGUI _highScoreText;
    [SerializeField] GameObject _bangbang; 
    
    private int _currScore;
    private int _highScore = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameController.Instance.Player.score += updateScore;
        GameController.Instance.Player.end += resetScore; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void updateScore()
    {
        _currScore++;
        _scoreText.text = "Score: " + _currScore; 

        if (_currScore > _highScore)
        {
            _bangbang.SetActive(true); 
            _highScore = _currScore;
            _highScoreText.text = "Highscore: " + _highScore; 
        }
    }

    void resetScore()
    {
        _currScore = 0;
        _bangbang.SetActive(false); 
    }

}
