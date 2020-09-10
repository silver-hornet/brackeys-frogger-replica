using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public static int currentScore = 0;

    void Start()
    {
        scoreText.text = currentScore.ToString();
    }
}
