using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
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

    void Update()
    {
        UpdateScore();
    }

    public void AddPoints(int points) {
        _score += points;
        UpdateScore();
    }

    private void UpdateScore() {
        _scoreText.text = "����: " + _score;
    }

    
}
