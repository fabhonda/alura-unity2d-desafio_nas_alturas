using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DificultyController : MonoBehaviour
{
    public float timeMaxLevel;
    public float Dificulty { get; private set; }
    private float timed;

    void Update()
    {
        timed += Time.deltaTime;
        Dificulty = timed / timeMaxLevel;
        Dificulty = Mathf.Min(1,Dificulty);
    }
}
