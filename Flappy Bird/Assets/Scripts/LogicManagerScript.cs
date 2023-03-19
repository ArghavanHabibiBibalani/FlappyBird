using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>

    public int playScore = 0;
    public Text scoreText;
    public GameObject gameOver;

    [ContextMenu("Increse Score")]
    public void AddScore(int scoreToAdd)
    {
        //[ContextMenu("Increse Score")]
        playScore += scoreToAdd;
        scoreText.text = playScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//LOADING OUR SCENE AGAIN

    }

    public void GameOver()
    {
        gameOver.SetActive(true);
    }
}
