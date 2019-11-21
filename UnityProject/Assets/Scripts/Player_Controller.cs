using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public Rigidbody rb;
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 200.0f;
    private int vides = 5;
    private float wallet;
    public GameObject tVides;
    public GameObject tMoney;

    AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "coin")
        {
            pickCoin(other);        
        }
        else if (other.tag == "enemy")
        {
            Destroy(other.gameObject);
            damage();
        }
    }

    public void damage()
    {
        vides -= 1;
        Debug.Log("Vides: " + vides);
        tVides.GetComponent<UnityEngine.UI.Text>().text = "Vides: " + vides;
        if (vides <= 0)
        {
            Debug.Log("You died");
            gameObject.SetActive(false);
        }
    }

    public void pickCoin(Collider other)
    {
        wallet++;
        Debug.Log("Coins: " + wallet);
        tMoney.GetComponent<UnityEngine.UI.Text>().text = "Monedes: " + wallet;
        Destroy(other.gameObject);
        audioData.Play(0);
        checkVictory();
    }

    public void checkVictory()
    {
        GameObject[] objects;

        objects = GameObject.FindGameObjectsWithTag("coin");
        Debug.Log(objects.Length);
        if (objects.Length <= 1)
        {
            Debug.Log("You Win!");
        }
    }

}
