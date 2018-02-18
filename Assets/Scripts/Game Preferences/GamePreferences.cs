using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GamePreferences
{

    public static string EasyDifficulty = "EasyDifficulty";
    public static string MediumDifficulty = "MediumDifficulty";
    public static string HardDifficulty = "HardDifficulty";
    public static string EasyDifficultyHighScore = "EasyDifficultyHighScore";
    public static string MediumDifficultyHighScore = "MediumDifficultyHighScore";
    public static string HardDifficultyHighScore = "HardDifficultyHighScore";
    public static string EasyDifficultyCoinScore = "EasyDifficultyCoinScore";
    public static string MediumDifficultyCoinScore = "MediumDifficultyCoinScore";
    public static string HardDifficultyCoinScore = "HardDifficultyCoinScore";
    public static string isMusicOn = "isMusicOn";

    public static void SetEasyDifficulty(int difficulty)
    {
        PlayerPrefs.SetInt(GamePreferences.EasyDifficulty, difficulty);
    }

    public static int GetEasyDifficulty()
    {
        return PlayerPrefs.GetInt(GamePreferences.EasyDifficulty);
    }

    public static void SetMusicState(int state)
    {
        PlayerPrefs.SetInt(GamePreferences.isMusicOn, state);
    }

    public static int GetMusicState()
    {
        return PlayerPrefs.GetInt(GamePreferences.isMusicOn);
    }

    public static void SetMediumDifficulty(int difficulty)
    {
        PlayerPrefs.SetInt(GamePreferences.MediumDifficulty, difficulty);
    }

    public static int GetMediumDifficulty()
    {
        return PlayerPrefs.GetInt(GamePreferences.MediumDifficulty);
    }

    public static void SetHardDifficulty(int difficulty)
    {
        PlayerPrefs.SetInt(GamePreferences.HardDifficulty, difficulty);
    }

    public static int GetHardDifficulty()
    {
        return PlayerPrefs.GetInt(GamePreferences.HardDifficulty);
    }

    public static void SetEasyDifficultyHighScore(int difficulty)
    {
        PlayerPrefs.SetInt(GamePreferences.EasyDifficultyHighScore, difficulty);
    }

    public static int GetEasyDifficultyHighScore()
    {
        return PlayerPrefs.GetInt(GamePreferences.EasyDifficultyHighScore);
    }

    public static void SetMediumDifficultyHighScore(int difficulty)
    {
        PlayerPrefs.SetInt(GamePreferences.MediumDifficultyHighScore, difficulty);
    }

    public static int GetMediumDifficultyHighScore()
    {
        return PlayerPrefs.GetInt(GamePreferences.MediumDifficultyHighScore);
    }

    public static void SetHardDifficultyHighScore(int difficulty)
    {
        PlayerPrefs.SetInt(GamePreferences.HardDifficultyHighScore, difficulty);
    }

    public static int GetHardDifficultyHighScore()
    {
        return PlayerPrefs.GetInt(GamePreferences.HardDifficultyHighScore);
    }

    public static void SetEasyDifficultyCoinScore(int difficulty)
    {
        PlayerPrefs.SetInt(GamePreferences.EasyDifficultyCoinScore, difficulty);
    }

    public static int GetEasyDifficultyCoinScore()
    {
        return PlayerPrefs.GetInt(GamePreferences.EasyDifficultyCoinScore);
    }

    public static void SetMediumDifficultyCoinScore(int difficulty)
    {
        PlayerPrefs.SetInt(GamePreferences.MediumDifficultyCoinScore, difficulty);
    }

    public static int GetMediumDifficultyCoinScore()
    {
        return PlayerPrefs.GetInt(GamePreferences.MediumDifficultyCoinScore);
    }

    public static void SetHardDifficultyCoinScore(int difficulty)
    {
        PlayerPrefs.SetInt(GamePreferences.HardDifficultyCoinScore, difficulty);
    }

    public static int GetHardDifficultyCoinScore()
    {
        return PlayerPrefs.GetInt(GamePreferences.HardDifficultyCoinScore);
    }





}

