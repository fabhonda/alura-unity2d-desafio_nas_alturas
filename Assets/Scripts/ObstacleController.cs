using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public SharedVariables velocity;

    void Update()
    {
        transform.Translate(Vector3.left * velocity.value * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Wall") Destroy(gameObject);
    }
}
