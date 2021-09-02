using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    public GameObject background;
    public Text text;
    private Canvas canvas;

    void Awake()
    {
        canvas = GetComponent<Canvas>();
    }

    public void ShowCanvas(Camera camera)
    {
        canvas.worldCamera = camera;
        background.SetActive(true);
    }

    public void HideCanvas()
    {
        background.SetActive(false);
    }

    public void RefreshText(int points)
    {
        text.text = points.ToString();
    }
}
