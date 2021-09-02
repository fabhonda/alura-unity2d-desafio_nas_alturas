using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public SharedVariables velocity;
    private Vector3 initialPosition;
    private float RealImageSize;

    void Awake()
    {
        initialPosition = transform.position;
        float imageSize = GetComponent<SpriteRenderer>().size.x;
        float scale = transform.localScale.x;
        RealImageSize = imageSize * scale;
    }
    void Update()
    {
        float displacement = Mathf.Repeat(velocity.value * Time.time,RealImageSize/4);
        transform.position = initialPosition + Vector3.left * displacement;
    }
}
