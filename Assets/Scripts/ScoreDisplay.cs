using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;

    private void Awake()
    {
        ScoreManager.OnScoreUpdated += UpdateScoreDisplay;
    }

    private void UpdateScoreDisplay(int newScore)
    {
        _scoreText.text = newScore.ToString();
    }
}
