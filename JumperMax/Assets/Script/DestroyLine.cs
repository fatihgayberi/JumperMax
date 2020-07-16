using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLine : MonoBehaviour
{
    public string nm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("update: " + nm);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NormalPlatform"))
        {
            Debug.Log("hello ammar");
        }
        nm = collision.gameObject.name;
        Debug.Log("name1:" + collision.gameObject.name);
        Debug.Log("name2:" + gameObject.name);
    }
    //void OnTriggerEnter2D (Collider2D collision)
    //{
    //    //Rigidbody2D rb2d = collision.collider.GetComponent<Rigidbody2D>();

    //    Debug.Log("name:" + collision.gameObject.name);


    //}
}
