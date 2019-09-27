using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public int score = 0;
    void Update()
    {
        scoreText.text = score.ToString("0");
        
    }
}
