﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    public ScoreManager score;
    public SpawnRedSquere redSquere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Obstacle")
        {
            transform.localScale += new Vector3(0.5f,0.5f,0.5f);
            score.scoreadd();
            Destroy(col.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "RedSquere")
        {
            transform.localScale += new Vector3(-0.5f,-0.5f,-0.5f);
            score.scoremin();
            redSquere.RedSquereSpawner();
            Destroy(other.gameObject);
        }
    }
}
