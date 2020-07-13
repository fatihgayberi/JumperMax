using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody2D playerRb/*, player2DTouchObject*/;
    private float moveSpeed = 400f;
    public GameObject player;
    

    void Start()
    {
        playerRb = player.GetComponent<Rigidbody2D>();
        //player2DTouchObject = player.GetComponent<Rigidbody2D>();
        //Rigidbody2D player2DTouchObject;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        int i = 0;

        while (i < Input.touchCount)
        { 
            if (Input.GetTouch(i).position.x < Screen.width / 2)
            {
                playerRb.AddForce(new Vector2(-1f * moveSpeed * Time.deltaTime, 0));
                //Debug.Log("Left click");
            }
            if (Input.GetTouch(i).position.x > Screen.width / 2)
            {
                playerRb.AddForce(new Vector2(1f * moveSpeed * Time.deltaTime, 0));
                //Debug.Log("Right click");
            }
            ++i;
        }
    }

    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    //player2DTouchObject = collision.collider.GetComponent<Rigidbody2D>();
    //}

    //void OnTriggerEnter2D(Collider2D collision)
    //{

    //    if (player2DTouchObject != null)
    //    {
    //        if (collision.gameObject.name.StartsWith("NormalPlatform"))
    //        {
    //            Debug.Log("name: " + collision.gameObject.name);

    //            Vector2 velocity = player2DTouchObject.velocity;
    //            velocity.y = 15f;
    //            player2DTouchObject.velocity = velocity;
    //        }
    //        else if (collision.gameObject.name.StartsWith("NormalPlatform"))
    //        {
    //            Debug.Log("name: " + collision.gameObject.name);
    //            Vector2 velocity = player2DTouchObject.velocity;
    //            velocity.y = 20f;
    //            player2DTouchObject.velocity = velocity;
    //        }
    //    }
        
    //}
}
