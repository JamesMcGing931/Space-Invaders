using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;

    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }
}