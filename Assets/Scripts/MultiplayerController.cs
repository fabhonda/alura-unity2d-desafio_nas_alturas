using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplayerController : GameController
{
    public int revivePoints;
    private Player[] players;
    private bool stopped;
    private int points;
    private CanvasController scriptCanvas;

    protected override void Start()
    {
        revivePoints = 2;
        base.Start();
        players = GameObject.FindObjectsOfType<Player>();
        scriptCanvas = GameObject.FindObjectOfType<CanvasController>();
    }

    public void Notify(Camera camera)
    {
        if (stopped)
        {
            scriptCanvas.HideCanvas();
            GameOver();
        }
        stopped = true;
        points = 0;
        scriptCanvas.ShowCanvas(camera);
        scriptCanvas.RefreshText(revivePoints);
    }

    public void ReviveCount()
    {
        if (stopped) 
        {
            points++;
            scriptCanvas.RefreshText(revivePoints-points);
            if (points >= revivePoints)
            {
                scriptCanvas.HideCanvas();
                RevivePlayers();
            }
        }
        
    }

    private void RevivePlayers()
    {
        stopped = false;
        foreach(var player in players)
        {
            player.Active();
        }
    }

    public override void Restart()
    {
        base.Restart();
        RevivePlayers();
    }
}
