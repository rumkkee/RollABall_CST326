using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int _score;

    public delegate void ScoreHandler(int currentScore);
    public static event ScoreHandler OnScoreUpdated;

    private void Awake()
    {
        Collectible.OnPickup += AddToScore;
    }

    private void AddToScore(int pointsToAdd)
    {
        _score += pointsToAdd;
        OnScoreUpdated(_score);
    }
}
