using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostAI : MonoBehaviour
{
    // Variable List
    public float ghostSpeed = 1f; // Speed of which ghosts travel
    public GameObject ghostStart; // Ghost spawn
    public boolean turnZero; 
    public boolean turnOne; // It turns
    public boolean turnTwo; 

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
    }


}
