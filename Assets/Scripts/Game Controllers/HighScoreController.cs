﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HighScoreController : MonoBehaviour {

    [SerializeField]
    private Text scoreText, coinText;

	// Use this for initialization
	void Start () {
        SetScoreBasedinDifficulty();
	}
	
    void SetScore(int score, int coinScore)
    {
        scoreText.text = "" + score;
        coinText.text = "" + coinScore;
    }

    void SetScoreBasedinDifficulty()
    {
        if (GamePreferences.GetEasyDifficulty() == 1)
        {
            SetScore(GamePreferences.GetEasyDifficultyHighScore(), GamePreferences.GetEasyDifficultyCoinScore());
        }
        if (GamePreferences.GetMediumDifficulty() == 1)
        {
            SetScore(GamePreferences.GetMediumDifficultyHighScore(), GamePreferences.GetMediumDifficultyCoinScore());
        }
        if (GamePreferences.GetHardDifficulty() == 1)
        {
            SetScore(GamePreferences.GetHardDifficultyHighScore(), GamePreferences.GetHardDifficultyCoinScore());
        }
    }

	public void GoBackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
