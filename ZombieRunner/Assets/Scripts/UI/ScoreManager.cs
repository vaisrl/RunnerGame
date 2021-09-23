using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public float score;
    public Text scoreDisplay;
    

    void Update()
    {
        score += Time.deltaTime;
        scoreDisplay.text = "Score: " + Mathf.Round(score).ToString();
    }

    public void UpdateScore()
    {
        score += 10f;
    }
}
