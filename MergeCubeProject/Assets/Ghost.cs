using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
      // Variable List
    public float ghostSpeed =  1f; // Speed of which ghosts travel
    public GameObject ghostStart; // Ghost spawn
    public bool turnZero = true; 
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
        if(Input.GetKey(KeyCode.W)) {// Moving forward
        if(turnZero == true)
        {
            transform.position += transform.forward * -ghostSpeed * Time.deltaTime;
            Debug.Log("Straight");
        }
        else if(turnOne == true)
        {
            transform.position += transform.right * ghostSpeed * Time.deltaTime;
            Debug.Log("right");
        }
        else if(turnTwo == true)
        {
            transform.position += transform.forward * -ghostSpeed * Time.deltaTime;
            Debug.Log("Left");
        }
    }
    }
    void OnTriggerEnter(Collider turns) // Bumping into things no more, now he turns!
    {

    
        if(turns.gameObject.name == "Base1")
        {
            turnZero = false;
            turnOne = true;
            Debug.Log("Turn right");
        }
        else if(turns.gameObject.name == "Base2")
        {
            turnOne = false;
            turnTwo = true;
        }
        else if(turns.gameObject.name == "Base3")
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



