using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class scoreCalculator : MonoBehaviour
{
    // Start is called before the first frame update

    public Text levelText;
    public Text scoreText;
    private int score;
    private int currentScene;
    private int oldScene;

    void Start()
    {
        int updatedScore;


        score = 10;

        oldScene = SceneManager.GetActiveScene().buildIndex - 1;
        currentScene = SceneManager.GetActiveScene().buildIndex;

        levelText.text = "Level " + currentScene;
        scoreText.text = "Score = " + score;
    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < currentScene; i++)
        {
            score = score + 10;
        }
  
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "walls")
        {
            score = score - 1;
        }

    }
}
