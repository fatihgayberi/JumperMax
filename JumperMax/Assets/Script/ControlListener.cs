using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlListener : MonoBehaviour
{
    public GameObject player;
    private float num = -1f;
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

        if (rb2d.name == "Player")
        {
            if (player.transform.position.x < 0)
            {
                player.transform.position = new Vector3(1f * player.transform.position.x + 0.5f, player.transform.position.y, player.transform.position.z);
            }
            if (player.transform.position.x > 0)
            {
                player.transform.position = new Vector3((-1f) * player.transform.position.x + 0.5f, player.transform.position.y, player.transform.position.z);
            }

        }

        
    }
}
