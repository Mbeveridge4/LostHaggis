using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;
    Rigidbody2D rb;
    // Update is called once per frame
    void Update()
    {
        //declares the rigidbody to be impacted by the script
        rb = GetComponent<Rigidbody2D>();

        // sets the multiplier when you start jumping
        if (rb.velocity.y <0)
        {
            rb.velocity += (fallMultiplier - 1) * Physics2D.gravity.y * Time.deltaTime * Vector2.up;
        }
        // sets the multiplier if falling so that you fall faster
        else if (rb.velocity.y > 0 && Input.GetKey (KeyCode.Space))
        {
            rb.velocity += (lowJumpMultiplier - 1) * Physics2D.gravity.y * Time.deltaTime * Vector2.up;
        }
    }
}
