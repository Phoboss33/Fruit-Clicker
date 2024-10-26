using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour {
    public static GameManager instance;

    [SerializeField] private TextMeshProUGUI _scoreText;

    private int _score = 0;
    private void Awake() {
        if (instance == null) {
            instance = this;
        }
        else {
            Destroy(gameObject);
        }
    }

    void FixedUpdate() {
        if (_score > 0) {
            _score -= 1;
        }
        UpdateScore();
        
    }

    public void AddPoints(int points) {
        _score += points;
        UpdateScore();
    }

    public void MinusPoints(int points) {
        _score -= points;
        UpdateScore();
    }

    private void UpdateScore() {
        _scoreText.text = "Очки: " + _score;
    }

    
}
