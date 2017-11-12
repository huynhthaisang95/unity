﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayController : MonoBehaviour {

    [SerializeField]
    private GameObject gameOverPanel;

    public static GamePlayController instance;
    void Awake()
    {
        MakeInstance();
    }

    void MakeInstance() {
        if(instance==null){
            instance = this;
        }
    }
   

    public void ResumeButton() {
        SceneManager.LoadScene("Island1");
        gameOverPanel.gameObject.SetActive(false);
    }

    public void OptionsButton() {

        SceneManager.LoadScene("MainMenu");
    }

    public void BoatDiedShowPanel() {
        gameOverPanel.gameObject.SetActive(true);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}


    
