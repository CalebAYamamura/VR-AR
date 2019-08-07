using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // List of Variables
    public float speed = 0.5f; // Speed of PacMan, can adjust
    public GameObject spawn_1; // Escape Routes for off screen "hallways"
    public int dotsLeft; // To count the Dots left
    public GameObject startPoint; // Returns the ghost to their spawn

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("dotsLeft"); // This will print the amount of dots left in the game
        ShowDots(); // Run the function "ShowDots"

        if(Input.GetKey(KeyCode.W)) // Moving forward
        {
            transform.position += transform.forward * speed * Time.deltaTime; // Movement
        }
        else if(Input.GetKey(KeyCode.S)) // Moving back
        {
            transform.position += transform.forward * -speed * Time.deltaTime; // Movement
        }
        else if(Input.GetKey(KeyCode.D)) // Moving to the right
        {
            transform.position += transform.right * speed * Time.deltaTime; // Movement
        }
        else if(Input.GetKey(KeyCode.A)) // Moving to the left
        {
            transform.position += transform.right * -speed * Time.deltaTime; // Movement
        }
        
    }
    void OnTriggerEnter(Collider gate) // Gate_1 and spawn_1
    {
        if (gate.gameObject.tag == "Gate_1")
        {
            transform.position = spawn_1.transform.position;
        }
    }
    void OnCollisionEnter(Collision collision) // Remove Dots on touch function
    {
        if(collision.gameObject.tag == "Dots")
        {
            dotsLeft--;
        }
        else if (collision.gameObject.tag == "Ghost")
        {
            transform.position = startPoint.transform.position;
        }
    }
    void ShowDots()
    {    
        if(dotsLeft == 0)
        {
            Debug.Log("You Win"); // Win Condition
        }
    }  
}
