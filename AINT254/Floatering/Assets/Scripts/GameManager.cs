using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   
    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Level1");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("MenuScreen");
    }


}
