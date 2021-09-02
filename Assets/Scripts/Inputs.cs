using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs : MonoBehaviour
{
    public KeyCode key;
    private PlaneController scriptPlane;

    void Start()
    {
        scriptPlane = GetComponent<PlaneController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            scriptPlane.goImpulse();
        }
    }
}
