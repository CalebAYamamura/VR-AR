using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    // Variable list
    public GameObject pointBall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision) // Points Gathered
    {
        if(collision.gameObject.tag == "Player")
        {
            (pointBall).SetActive(false);
        }
    }
}
