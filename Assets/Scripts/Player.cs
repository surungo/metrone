using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxSpeed;

    private float speed;
    private Rigidbody2D rb;
    private bool facingRight = true;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = maxSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(h * speed, rb.velocity.y);

        if(h > 0 && !facingRight)
        {
            Flip();
        }else if (h < 0 && facingRight)
        {
            Flip();
        }

    }

    void Flip()
    {
        facingRight = !facingRight;

        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
