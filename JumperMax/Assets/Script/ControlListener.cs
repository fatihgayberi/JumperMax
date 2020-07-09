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

        //Debug.Log("name: " + rb2d);
        //if (rb2d.name == "Player")
        {
            if (player.transform.position.x < 0) //left ending
            {
                player.transform.position = new Vector3((-1f) * player.transform.position.x - 0.5f, player.transform.position.y, player.transform.position.z);
                //Debug.Log("player: " + player.transform.position.x + "\nleft duvar: " + (-1f * player.transform.position.x + 0.5f));
            }
            else if (player.transform.position.x > 0) // right ending
            {
                player.transform.position = new Vector3((-1f) * player.transform.position.x + 0.5f, player.transform.position.y, player.transform.position.z);
                //Debug.Log("la right la");
            }

        }

    }
}
