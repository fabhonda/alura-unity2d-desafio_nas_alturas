using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public float[] ranges;
    public GameObject obstacle;
    public float timeEasy;
    public float timeHard;
    private float cronometer;
    private DificultyController scriptDificulty;
    private bool stopped;

    private void Awake()
    {
        cronometer = timeEasy;
    }

    void Start()
    {
        scriptDificulty = FindObjectOfType<DificultyController>();
    }
    void Update()
    {
        if (stopped) return;
        cronometer -= Time.deltaTime;
        if (cronometer < 0)
        {
            Vector3 position = new Vector3(transform.position.x,Random.Range(ranges[0],ranges[1]),0);
            GameObject.Instantiate(obstacle,position,Quaternion.identity);
            cronometer = Mathf.Lerp(timeEasy, timeHard, scriptDificulty.Dificulty);
        }
    }

    public void Stop()
    {
        stopped = true;
    }

    public void Restart()
    {
        stopped = false;
    }
}
