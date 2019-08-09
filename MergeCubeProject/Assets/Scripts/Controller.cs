using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    // List of Variables
    public float speed = 0.5f; // Speed of PacMan, can adjust
    public GameObject spawn_1; // Escape Routes for off screen "hallways"
    public GameObject spawn_2; // ^Same
    public int dotsLeft; // To count the Dots left
    public GameObject startPoint; // Returns the ghost to their spawn

    // List of Game States
    public enum screen {menu, countdown, game, win, lose,}; // Different screens

    // Game state variable 
    screen currentScreen; // What screen is on the screen

    // Menu UI elements
    public Text welcome;
    public Text instruction;
    public GameObject startButton;

    // Player Controller UI Elements
    public GameObject upButton;
    public GameObject downButton;
    public GameObject rightButton;
    public GameObject leftButton;

    // Start is called before the first frame update
    void Start() // Dot Count til win Condition
    {
        dotsLeft = 40;
        currentScreen = screen.menu; 
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(dotsLeft); // This will print the amount of dots left in the game
        ShowDots(); // Run the function "ShowDots"

        if(Input.GetKey(KeyCode.W)) // Moving forward
        {
            MoveUp(); // Movement
        }
        else if(Input.GetKey(KeyCode.S)) // Moving back
        {
            MoveDown(); // Movement
        }
        else if(Input.GetKey(KeyCode.D)) // Moving to the right
        {
            MoveLeft(); // Movement
        }
        else if(Input.GetKey(KeyCode.A)) // Moving to the left
        {
            MoveRight(); // Movement
        } // Better Movement
        
     
    }
    void OnTriggerEnter(Collider gate) // Gate_1 and spawn_1
    {
        if (gate.gameObject.tag == "Gate_1")
        {
            transform.position = spawn_1.transform.position;
        }
                                      // Gate_2 and spawn_2
        else if (gate.gameObject.tag == "Gate_2")
        {
            transform.position = spawn_2.transform.position;
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
    void ShowDots() // Win Condition
    {    
        if(dotsLeft == 0)
        {
            Debug.Log("You Win"); // Win Condition
        }
    }
    public void MoveUp()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        Debug.Log("Move Up"); 
    }
    public void MoveDown()
    {
        transform.position += transform.forward * -speed * Time.deltaTime;
    }  
    public void MoveLeft()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }
    public void MoveRight()
    {
        transform.position += transform.right * -speed * Time.deltaTime;
    }
   /*  public void GameState() // Continue later???    
    {
        welcome.text = "Welcome to Pacman";

        if (currentScreen == screen.menu)
        {
            upButton.SetActive(false);
            downButton.SetActive(false);
            rightButton.SetActive(false);
            leftButton.SetActive(false);
        }
        else if (currentScreen == screen.countdown)
        {

        }
        else if (currentScreen == screen.game)
        {

        }
        else if (currentScreen == screen.win)
        {

        }
        else if (currentScreen == screen.lose)
        {

        }
    }*/
}
