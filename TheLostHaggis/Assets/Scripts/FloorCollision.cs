using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //thing we ran into
        GameObject otherObject = collision.gameObject;

        //gets the name of the object
        string otherName = otherObject.name;

        //check the tag on the object
        string otherTag = otherObject.tag;

        //we can get sorting layer of the object
        int layer = otherObject.layer;

        //we canm check if a script is on the object
        //getting a componetnt
        SpriteRenderer spriteRenderer = otherObject.GetComponent<SpriteRenderer>();

        Debug.Log("Collison");
        Debug.Log("Name" + otherName);
        Debug.Log("Tag" + otherTag);
        if (spriteRenderer != null)
        {
        //    spriteRenderer.color = Color.green;
        }


    }
}
