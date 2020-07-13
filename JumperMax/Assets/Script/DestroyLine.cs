using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D collision)
    {
        //Rigidbody2D rb2d = collision.collider.GetComponent<Rigidbody2D>();

        Debug.Log("name:" + collision.gameObject.name);


    }
}
