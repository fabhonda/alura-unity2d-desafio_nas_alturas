using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPlayer : MonoBehaviour
{
    public float impulseGap;
    private PlaneController scriptPlane;

    void Start()
    {
        scriptPlane = GetComponent<PlaneController>();
        StartCoroutine(Impulse());
    }

    IEnumerator Impulse()
    {
        while (true)
        {
            yield return new WaitForSeconds(impulseGap);
            scriptPlane.goImpulse();
        }

    }
}
