﻿﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public static HUD HUDManager;
    public GameObject AudioSourceObject;
    [SerializeField] private Text Txt_Score = null;
    [SerializeField] private Image Image_Lives = null;
    [SerializeField] private Text Txt_Message = null;
    public AudioSource bgm;
 
    void Start()
    {
        HUDManager = this;
    }

    public void UpdateScore()
    {
        Txt_Score.text = "SCORE : " + GameManager.Score;
    }

    //updates the number of hearts for lives
    public void UpdateLives()
    {
        Image_Lives.rectTransform.sizeDelta = new Vector2(GameManager.Lives * 50, 30);

    }

    public void GameOver()
    {
        Time.timeScale = 0;
        GameManager.CurrentState = GameManager.GameState.GameOver;
        Txt_Message.color = Color.red;
        Txt_Message.text = "GAME OVER! \n PRESS ENTER TO RESTART GAME.";
        AudioSourceObject.GetComponent<AudioSource>().Stop();

     
    }

    public void DismissMessage()
    {
        Txt_Message.text = "";
    }
}
