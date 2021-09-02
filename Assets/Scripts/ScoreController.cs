using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ScoreController : MonoBehaviour
{
    public UnityEvent whenScore;
    public Text textScore;
    public int Score { get; private set; }
    private AudioSource audioScore;

    void Awake()
    {
        audioScore = GetComponent<AudioSource>();
    }

    void Start()
    {
        textScore.text = "SCORE: 0";
        Score = 0;
    }

    public void addScore()
    {
        Score++;
        textScore.text = "SCORE: " + Score.ToString();
        audioScore.Play();
        whenScore.Invoke();
    }

    public void maxScore()
    {
        if(Score > PlayerPrefs.GetInt("score"))
        {
            PlayerPrefs.SetInt("score", Score);
        }
    }
}
