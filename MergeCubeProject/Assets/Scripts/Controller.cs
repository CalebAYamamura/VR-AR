using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // List of Variables
    public float speed = 1f; // Speed of PacMan, can adjust
    public gameObject spawn_1; // Escape Routes for off screen "hallways"

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) // moving? Input?
        {
            transform.position += transform.forward * speed * Time.deltaTime; // Movement
        }
    }
    void OnTriggerEnter(Collider gate)
    {
        if (gate.gameObject.tag == "Gate_1")
        {
            transform.position = spawn_1.transform.position;
        }
    }   
}
