using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    //Variables list
    public float speed = 0.5f; //Helps control the speed of our movement
    public GameObject Camera; //Can be used in reference to our camera object
    public Vector3 spawnPoint; //When game starts, where you go 
    public GameObject Door; //A door that is closed, needs a key
    public GameObject Key; // The key for said door
    public bool gotKey = false;
    public bool doorUnlocked = false;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = transform; //Setting the location of the Transform set to our VR camera's starting position when the game begins.

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        { 
            transform.position = transform.position + Camera.transform.forward * speed * Time.deltaTime;
        }
        else if (Input.touchCount > 0)
        {
            transform.position = transform.position + Camera.transform.forward * speed * Time.deltaTime;
        }
        if (doorUnlocked == true)
        {
            OpenDoor();
        }
    }
    void OnTriggerEnter(Collider collide)
    {
        
        if(collide.gameObject.tag == "Respawn")
        {
            transform.position = spawnPoint;
            Debug.Log("collide");
        }

        else if (collide.gameObject.tag == "Door")
        {
            doorUnlocked = true;
        }
    }
    void OpenDoor()
    {
        Quaternion newRotation = Quaternion.AngleAxis(-90, Vector3.up);

            Door.transform.rotation = Quaternion.Slerp(Door.transform.rotation, newRotation, .05f);

            Door.tag = "Untagged";
    }
    void OnCollisionEnter (Collision collision)
    {
    
        if(collide.gameObject.tag == "Key")
        {
            gotKey = true;
            Destroy(Key);
        }
    }
}   

