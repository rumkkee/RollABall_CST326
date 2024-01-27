using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeReference] private GameObject _winPanel;
    [SerializeField] private int _scoreToWin;

    private void Awake()
    {
        ScoreManager.OnScoreUpdated += CheckWinCondition;
    }

    private void CheckWinCondition(int currentScore)
    {
        if(currentScore >= _scoreToWin)
        {
            _winPanel.SetActive(true);
        }
    }
}
