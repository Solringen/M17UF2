using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IniciRotacio : MonoBehaviour {
    public float speed = 0.01f;

    // Use this for initialization
    void Start () {
		
	}
	
	
    void Update()
    {
       


       transform.eulerAngles = new Vector3(transform.eulerAngles.x,transform.eulerAngles.y + speed/10);

    }
}
