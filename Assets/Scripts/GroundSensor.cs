using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D Collider)
    {
        isGrounded = true;
    }
     void OnTriggerExit2D(Collider2D Collider)
    {
        isGrounded = false;
    }
}
