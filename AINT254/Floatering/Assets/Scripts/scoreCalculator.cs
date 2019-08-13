using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class scoreCalculator : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Text levelText;
    public Text scoreText;
    private int score;
    private int updatedScore;

    private int currentScene;
    private int oldScene;

    new GameObject gameObject;
    new Collider collider;
    void Start()
    {

        score = 10;
        oldScene = SceneManager.GetActiveScene().buildIndex - 1;
        currentScene = SceneManager.GetActiveScene().buildIndex;
        levelText.text = "Level " + currentScene;
        scoreText.text = "Score = " + score;


    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //for (int i = 0; i < currentScene; i++)
        //{
        //    score = score + 10;
        //}
        scoreText.text = "Score = " + player.position.z.ToString("0");

        PlayerPrefs.SetInt("Player Score", score);

    }


}
