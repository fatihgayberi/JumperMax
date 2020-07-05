using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody2D playerRb, rightRb, leftRb;
    private float moveSpeed = 400f;
    public GameObject player, controlR, controlL;

    void Start()
    {
        playerRb = player.GetComponent<Rigidbody2D>();
        rightRb = controlR.GetComponent<Rigidbody2D>();
        leftRb = controlL.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        int i = 0;

        while (i < Input.touchCount)
        {
            //var touch = Input.GetTouch(0);
            if (Input.GetTouch (i).position.x < Screen.width / 2)
            {
                playerRb.AddForce(new Vector2(-1f * moveSpeed * Time.deltaTime, 0));
                //rb2d.velocity = new Vector2(rb2d.velocity.x - 1f, rb2d.velocity.y);
                Debug.Log("Left click");
            }
            if (Input.GetTouch(i).position.x > Screen.width / 2)
            {
                playerRb.AddForce(new Vector2(1f * moveSpeed * Time.deltaTime, 0));

                //if (rightRb != null)
                {
                    //Debug.Log("la la la");
                    //
                }
                //rb2d.velocity = new Vector2(rb2d.velocity.x + 1f, rb2d.velocity.y);
                Debug.Log("Right click");
            }
            ++i;
        }
    }
}
