using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rBody;
    public float movementSpeed = 5;
    private SpriteRenderer spriterenderer;
    public GroundSensor sensor;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        spriterenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        rBody.velocity = new Vector2(inputHorizontal * movementSpeed , rBody.velocity.y);

        if(inputHorizontal > 0)
        {
            spriterenderer.flipX = false;
        }
        else if(inputHorizontal < 0)
        {
            spriterenderer.flipX = true;
        }
        if(Input.GetButtonDown("Jump") && sensor.isGrounded)
        {
            rBody.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
        }
    }
}
