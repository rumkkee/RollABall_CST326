using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;

    private void Awake()
    {
        ScoreManager.OnScoreUpdated += UpdateScoreDisplay;
    }

    private void UpdateScoreDisplay(int newScore)
    {
        scoreText.text = newScore.ToString();
    }
}
