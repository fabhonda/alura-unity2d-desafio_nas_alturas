using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private ScoreController scriptScore;
    private InterfaceController scriptInterface;

    protected virtual void Start()
    {
        scriptScore = GameObject.FindObjectOfType<ScoreController>();
        scriptInterface = GameObject.FindObjectOfType<InterfaceController>();
        scriptInterface.showGameOver(false);
    }
    public void GameOver()
    {
        Time.timeScale = 0;
        scriptInterface.showGameOver(true);
        scriptScore.maxScore();
        scriptInterface.refreshRecord();
    }

    public virtual void Restart()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }
}
