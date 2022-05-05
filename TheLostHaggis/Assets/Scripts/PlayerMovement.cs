using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();
            ourRigidbody.AddForce(Vector2.right * speed);
            Debug.Log("Rightkey Pressed");

        }
    }
}
