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
        
    }

    // Update is called once per frame
    void Update()
    {
        if(turnZero == true)
        {
            transform.position += transform.forward * ghostSpeed * Time.deltaTime;
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
    void OnTriggerEnter(Collider turns)
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
    }
}



