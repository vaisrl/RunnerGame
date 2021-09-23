using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text scoreDisplay;    

    private void Update()
    {
        scoreDisplay.text = "Your score is: " + Mathf.Round(FindObjectOfType<ScoreManager>().score).ToString();
    }

}
