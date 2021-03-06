﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [Header("Platform Variables")]
    public Transform[] spawnPositions;
    public Transform endPosition;

    [Tooltip("End pos of Background tiles")]
    public Transform endPosBG;
    public Transform endPosFire;
    int currentScore = 0;

    public PlayerController player;


    public Text score;

    [HideInInspector]
    public CameraController cam;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        cam = Camera.main.GetComponent<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = currentScore + "";
    }

    public void AddScore()
    {
        currentScore++;
    }

    public void RestartGame()
    {
        SceneManager.LoadSceneAsync(0);
    }
}