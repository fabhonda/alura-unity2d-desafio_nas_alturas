using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlaneController : MonoBehaviour
{
    public UnityEvent whenStop;
    private Rigidbody2D rgb;
    public float force = 10;
    private bool allowImpulse=false;
    private Animator animatorPlane;
    private ScoreController scriptScore;
    private Vector3 initialPosition;


    void Awake()
    {
        initialPosition = transform.position;
        animatorPlane = GetComponent<Animator>();
        rgb = GetComponent<Rigidbody2D>();
        scriptScore = GameObject.FindObjectOfType<ScoreController>();
    }

    void Update()
    {
        animatorPlane.SetFloat("VelocityY",rgb.velocity.y);
    }

    void FixedUpdate()
    {
        if(allowImpulse) Impulse();
    }

    public void goImpulse()
    {
        allowImpulse = true;
    }

    private void Impulse()
    {
        rgb.velocity = Vector2.zero;
        rgb.AddForce(Vector2.up*force, ForceMode2D.Impulse);
        allowImpulse = false;
    }

    public void Restart()
    {
        transform.position = initialPosition;
        rgb.simulated = true;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Limit")
        {
            rgb.simulated = false;
            whenStop.Invoke();
            //scriptGameController.GameOver();
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        scriptScore.addScore();
    }
}
