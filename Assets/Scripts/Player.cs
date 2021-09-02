using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Parallax[] scenario;
    private ObstacleGenerator scriptObstacle;
    private PlaneController scriptPlane;
    private bool stopped;

    private void Start()
    {
        scenario = GetComponentsInChildren<Parallax>();
        scriptObstacle = GetComponentInChildren<ObstacleGenerator>();
        scriptPlane = GetComponentInChildren<PlaneController>();
    }

    public void Desactive()
    {
        stopped = true;
        scriptObstacle.Stop();
        foreach (var parallax in scenario)
        {
            parallax.enabled = false;
        }
    }

    public void Active()
    {
        if (stopped)
        {
            scriptPlane.Restart();
            scriptObstacle.Restart();
            foreach (var parallax in scenario)
            {
                parallax.enabled = true;
            }
            stopped = false;
        }

    }
}
