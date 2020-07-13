using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlListener : MonoBehaviour
{
    public GameObject player;
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

        {
            if (player.transform.position.x < 0) //left ending
            {
                player.transform.position = new Vector3((-1f) * player.transform.position.x - 0.5f, player.transform.position.y, player.transform.position.z);
            }
            else if (player.transform.position.x > 0) // right ending
            {
                player.transform.position = new Vector3((-1f) * player.transform.position.x + 0.5f, player.transform.position.y, player.transform.position.z);
            }

        }

    }
}
