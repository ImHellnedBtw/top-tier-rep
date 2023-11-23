using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class InformationController : MonoBehaviour 
{
    
    [HideInInspector] public static string PlayerName;
    [HideInInspector] public static Texture PlayerAvatar;
    [HideInInspector] public static int BestScore;
    [HideInInspector] public static int LastScore;

    public void Awake()
    {
        PlayerName = PlayerPrefs.GetString("PlayerName");
        BestScore = PlayerPrefs.GetInt("BestScore");
        LastScore = PlayerPrefs.GetInt("LastScore");
    }
    public void OnDestroy()
    {
        PlayerPrefs.SetString("PlayerName", PlayerName);
        PlayerPrefs.SetInt("BestScore", BestScore);
        PlayerPrefs.SetInt("LastScore", LastScore);
    }
}
