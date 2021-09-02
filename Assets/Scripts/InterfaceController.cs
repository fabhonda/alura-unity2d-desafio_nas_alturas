using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceController : MonoBehaviour
{
    public GameObject GameOverImage;
    public Sprite[] medals;
    public Text textRecord;
    public Image medal;
    private ScoreController scriptScore;
    private int record;

    private void Start()
    {
        scriptScore = GameObject.FindObjectOfType<ScoreController>();
    }

    public void refreshRecord()
    {
        record = PlayerPrefs.GetInt("score");
        textRecord.text = record.ToString();
        verifyMedal();
    }

    public void showGameOver(bool show)
    {
        GameOverImage.SetActive(show);
    }

    private void verifyMedal()
    {
        if(scriptScore.Score > record-2)
        {
            medal.sprite = medals[0];
        } else if(scriptScore.Score > record / 2)
        {
            medal.sprite = medals[1];
        }
        else
        {
            medal.sprite = medals[2];
        }
    }
}
