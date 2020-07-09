using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public GameObject player;
    //public GameObject scene;
    public float normalJumpPower = 15f, extraJumpPower = 20f;
    public float firstHigh, endHigh;
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
            if (rb2d.gameObject.name.StartsWith("Normal"))
            {
                Debug.Log("Line 29");
                Vector2 velocity = rb2d.velocity;
                velocity.y = normalJumpPower;
                rb2d.velocity = velocity;
                //endHigh = player.transform.position.y;

                //Debug.Log("firstHigh: " + firstHigh + "  endHigh: " + endHigh);
            }
            else
            {
                Debug.Log("olmuyo");
            }
            /*else if (collision.gameObject.name.StartsWith("JumpPlatform"))
            {
                Vector2 velocity = rb2d.velocity;
                velocity.y = extraJumpPower;
                rb2d.velocity = velocity;
                endHigh = player.transform.position.y;
            }*/
        }

    }
}
