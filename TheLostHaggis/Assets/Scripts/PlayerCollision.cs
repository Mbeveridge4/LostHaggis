using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    // CONDITION:
    // "If our object began collidiing with another one..."
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // INSERT ACTION HERE!

        // You can add further conditions such as...

        // CONDITION:
        // "If the object we collided with is called..."
        if (collision.gameObject.name == "TheChild")
        {
            // INSERT ACTION HERE!
        }

        // CONDITION:
        // "If the object we collided with has the tag..."
        if (collision.gameObject.tag == "REPLACE WITH TAG NAME")
        {
            // INSERT ACTION HERE!
        }

        // CONDITION:
        // "If the object we collided with is on the layer..."
        if (collision.gameObject.layer == LayerMask.NameToLayer("REPLACE WITH LAYER NAME"))
        {
            // INSERT ACTION HERE!
        }

        // CONDITION:
        // "If the object we collided with has a certain script or component on it..."
        // (Replace COMPONENT with the component type name)
        COMPONENT otherComponent = collision.gameObject.GetComponent<COMPONENT>(); // Gets the component from the other object and stores it
        if (otherComponent != null) // Checks if the component was actually retrieved from the other object - if it is not empty (null), it exists on the other object!
        {
            // INSERT ACTION HERE!
            // Note that you can access the component on the other object using the otherComponent variable
        }
    }

}