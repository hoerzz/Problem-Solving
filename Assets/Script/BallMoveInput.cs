using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMoveInput : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //input ketika menekan tombol a dan d
        float horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(speed * horizontal, rb.velocity.y);
        //input ketika menekan tombol w dan s
        float vertical = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, speed*vertical);
    }
}
