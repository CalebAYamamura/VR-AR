using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
      // Variable List
    public float ghostSpeed = 1f; // Speed of which ghosts travel
    public GameObject ghostStart; // Ghost spawn
    public bool turnZero = false; 
    public bool turnOne = false; 
    public bool turnTwo = false;


    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreLayerCollision(9, 10);
    }

    // Update is called once per frame
    void Update() // Ghost Movement
    {
        if(turnZero == true)
        {
            transform.position += transform.forward * -ghostSpeed * Time.deltaTime;
        }
        else if(turnOne == true)
        {
            transform.position += transform.right * ghostSpeed * Time.deltaTime;
        }
        else if(turnTwo == true)
        {
            transform.position += transform.forward * -ghostSpeed * Time.deltaTime;
        }
    }
    void OnTriggerEnter(Collider turns) // Bumping into things no more, now he turns!
    {
        if(turns.gameObject.name == "Base 1")
        {
            turnZero = false;
            turnOne = true;
            Debug.Log("Turn right");
        }
        else if(turns.gameObject.name == "Base 2")
        {
            turnOne = false;
            turnTwo = true;
        }
        else if(turns.gameObject.name == "Base 3")
        {
            turnZero = true;
            turnTwo = false;
        }
    }
    void OnCollisionEnter(Collision collision) // Lose Condition
    {
        if(collision.gameObject.tag == "Player")
        {
            transform.position = ghostStart.transform.position;
        }
    }
}



