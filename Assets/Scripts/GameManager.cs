using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeReference] private GameObject WinPanel;
    [SerializeField] private int scoreToWin;

    private void Awake()
    {
        ScoreManager.OnScoreUpdated += CheckWinCondition;
    }

    private void CheckWinCondition(int currentScore)
    {
        if(currentScore >= scoreToWin)
        {
            WinPanel.SetActive(true);
        }
    }
}
