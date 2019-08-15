﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseGame : MonoBehaviour
{

    public static bool isGamePaused = false;

    public GameObject pauseMenu;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }

       void Resume()
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
            isGamePaused = false;
        }

       void Pause()
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            isGamePaused = true;
        }
    }
}
