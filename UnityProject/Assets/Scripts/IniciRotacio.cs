using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IniciRotacio : MonoBehaviour
{
    public float speed = 0.01f;
    public Button ButtonExit;
    public Button ButtonStart;
    public Button ButtonOpcions;
    // Use this for initialization
    void Start()
    {

    }


    void Update()
    {
        //rotacion de camera 
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + speed / 10);

        //Botones
        ButtonExit.onClick.AddListener(BExit);
        ButtonStart.onClick.AddListener(BStart);
        ButtonOpcions.onClick.AddListener(BOpcions);
    }
   
    //metodo de "Button Exit"
    void BExit()
    {
        Debug.Log("Has pulsado Button Exit !");
    }
   
  
    void BStart()
    {
        Debug.Log("Has pulsado Button Start !");
    }


    void BOpcions()
    {
        Debug.Log("Has pulsado Button Opcions !");
    }
}
