using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTimer : MonoBehaviour
{
    public int score = 0;
    public int highScore = 0;
    public float timer = 0f;
    public float timerRate = 1f;
    public bool gameOn;
    public Text scoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        //set the Highscore when a game starts
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        gameOn = true;
    }

    //keep track of Highscore when game saved 
    void OnDestroy()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * timerRate;

        //when a second passes continue to add one to the score
        if (timer >= 1f && gameOn)
        {
            score++;
            scoreDisplay.text = "Timer: " + score.ToString();
            timer = 0f;

            //checks to see if player get the highscore
            if (score > highScore) highScore = score;
        }
    }
    // checks to see if player crossed finish line
    private void OnTriggerEnter(Collider other)
    {
        gameOn = false;
        Application.Quit();
    }
}
