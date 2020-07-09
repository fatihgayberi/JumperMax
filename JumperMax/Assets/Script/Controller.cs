using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody2D playerRb;
    private float moveSpeed = 400f;
    public GameObject player;

    void Start()
    {
        playerRb = player.GetComponent<Rigidbody2D>();
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
}
