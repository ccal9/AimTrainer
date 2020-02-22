using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [Header("Set Dynamically")]
    public static Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        GameObject curScore = GameObject.Find("ScoreCount");

        scoreText = curScore.GetComponent<Text>();
        scoreText.text = "Score: " + AimTrainer.score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
