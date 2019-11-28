using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Controller : MonoBehaviour
{

    //private Vector3 dist;
    public float speed;
    private GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
      //  dist = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z);
       // transform.position = Vector3.MoveTowards(transform.position, dist, speed * Time.deltaTime);
    }
}
