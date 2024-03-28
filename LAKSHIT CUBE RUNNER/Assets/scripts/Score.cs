using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text finalscoretext;
    public Text ScoreText;
    int myScore = 0;
   // Update is called once per frame
    void Update()
    {
        finalscoretext.text =  "score: " + myScore.ToString();
        ScoreText.text = myScore.ToString();
    }
    public void AddScore(int score)
    {
        myScore=myScore+score;
    }
}
