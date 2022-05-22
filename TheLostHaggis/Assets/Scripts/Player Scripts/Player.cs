using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int level;
    public Vector2 currentPosition;
    public Rigidbody2D RigidBody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D RigidBody = GetComponent<Rigidbody2D>();
        currentPosition = RigidBody.position;
    }
}
