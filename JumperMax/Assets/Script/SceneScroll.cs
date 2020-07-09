using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneScroll : MonoBehaviour
{
    public GameObject player;
    public GameObject scene;
    //public float firstHigh, endHigh;
    // Start is called before the first frame update
    void Start()
    {
        
        scene = GameObject.Find("Scene");

    }

    // Update is called once per frame
    void Update()
    {
        //firstHigh = player.transform.position.y;
        //scene.transform.position = new Vector2(scene.transform.position.x, player.transform.position.y);
        //endHigh = player.transform.position.y;

        //Debug.Log("firstHigh: " + firstHigh + "   endHigh: " + endHigh);
        /*if (player.transform.position.y )
        {

        }*/
        scene.transform.position = new Vector2(scene.transform.position.x, player.transform.position.y);
    }
}
