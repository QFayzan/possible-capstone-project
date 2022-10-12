using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static float score = 0;
    public TextMeshProUGUI scoreText;

    void Update()
    {
        scoreText.text = "Score : " + score.ToString();
        //Debug.Log(score);
    }
}