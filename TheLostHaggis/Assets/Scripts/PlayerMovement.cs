using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpVelocity = 4f;
    public Rigidbody2D RigidBody;
    public int jumpCount = 2;

    public void Update()
    {
        Rigidbody2D RigidBody = GetComponent<Rigidbody2D>();
        if (Input.GetKey(KeyCode.A))
            RigidBody.AddForce(Vector2.left);
        if (Input.GetKey(KeyCode.D))
            RigidBody.AddForce(Vector2.right);
        if (Input.GetKey(KeyCode.W))
            RigidBody.AddForce(Vector2.up);
        if (Input.GetKey(KeyCode.S))
            RigidBody.AddForce(Vector2.down);
        if (Input.GetKey(KeyCode.Space) && jumpCount > 0)
        {
            RigidBody.velocity = Vector2.up * jumpVelocity;
            //jumpCount--;
        }
    }
    
    
   
    
}
