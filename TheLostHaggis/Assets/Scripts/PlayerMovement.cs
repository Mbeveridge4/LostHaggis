using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //sets the jump speed
    public float jumpVelocity = 4f;
    public Rigidbody2D RigidBody;
    //sets the max number of jumps by default
    //public int jumpCount = 2;

    public void Update()
    {
        // applies force to the rigidbody based off player key input.
        Rigidbody2D RigidBody = GetComponent<Rigidbody2D>();
        if (Input.GetKey(KeyCode.A))
            RigidBody.AddForce(Vector2.left);
        if (Input.GetKey(KeyCode.D))
            RigidBody.AddForce(Vector2.right);

        // additional code if we wish to add up and down movement. Disabled for child.
        // if (Input.GetKey(KeyCode.W))
        //   RigidBody.AddForce(Vector2.up);
        // if (Input.GetKey(KeyCode.S))
        //     RigidBody.AddForce(Vector2.down);
       
        // makes the player jump if space is pressed. Jump key is disabled after set jumps used until reset using jumpCount. 
        if (Input.GetKey(KeyCode.Space))
        {
           RigidBody.velocity = Vector2.up * jumpVelocity;
        //jumpCount--;
        }
       
    }
    
    
   
    
}
