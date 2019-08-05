using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // List of Variables
    public GameObject player2;
    public float Speed = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right*Speed*Time.deltaTime;

        player2.transform.position += Vector3.right * Speed * Time.deltaTime;

        
    }
}
