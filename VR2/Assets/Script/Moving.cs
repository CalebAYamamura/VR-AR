using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    //Variables list
    public float speed = 0.5f; //Helps control the speed of our movement
    public GameObject Camera; //Can be used in reference to our camera object

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)){ 
            transform.position = transform.position + Camera.transform.forward * speed * Time.deltaTime;
        }
        else if (Input.touchCount > 0){
            transform.position = transform.position + Camera.transform.forward * speed * Time.deltaTime;
        }
    }
}
