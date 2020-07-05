using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlListenerL : MonoBehaviour
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

        if (rb2d.name == "Player")
        {
            player.transform.position = new Vector2(3f, player.transform.position.y);
        }
    }
}
