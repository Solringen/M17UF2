using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Controller : MonoBehaviour
{
    public float seconds = 0;
    public float secondsM = 0;
    private GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;
        seconds += Time.deltaTime;

        if (seconds >= 4f)
        {
            GameObject instance = Instantiate(Resources.Load("Enemy", typeof(GameObject)), this.transform.position, transform.rotation) as GameObject;
            seconds = 0f;       
        }
        if (seconds >= 3f)
        {
            GameObject instance = Instantiate(Resources.Load("Enemy", typeof(GameObject)), this.transform.position, transform.rotation) as GameObject;
            seconds = 0f;
        }
    }
}
