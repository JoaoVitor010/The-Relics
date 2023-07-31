using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public static GameController instance;

    public int score;
    public Text scoreText;
    
    public int rlq;
    public Text rlqText;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void UpdateScore(int value)
    {
        score += value;
        scoreText.text = score.ToString();
    }
    
    public void UpdateRlq(int value1)
    {
        rlq += value1;
        rlqText.text = rlq.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
