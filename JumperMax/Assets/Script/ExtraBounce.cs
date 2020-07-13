using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraBounce : MonoBehaviour
{
    public float extraJumpPower = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb2d = collision.collider.GetComponent<Rigidbody2D>();

        if (rb2d != null)
        {
            Vector2 velocity = rb2d.velocity;
            velocity.y = extraJumpPower;
            rb2d.velocity = velocity;         
        }
    }
}
