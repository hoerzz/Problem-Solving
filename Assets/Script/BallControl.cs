using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    public float xForce;
    public float yForce;
    public float BallSpeed;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        PushBall();
    }
    //Bola bergerak random dengan kecepatan konstan
    void PushBall()
    {
        float arahRandom = Random.Range(0, 2);
        if (arahRandom < 1.0f)
        {
            rigidbody2D.AddForce(new Vector2(-xForce, yForce).normalized * BallSpeed);
        }
        else
        {
            rigidbody2D.AddForce(new Vector2(xForce, yForce).normalized * BallSpeed);
        }
    }
}
