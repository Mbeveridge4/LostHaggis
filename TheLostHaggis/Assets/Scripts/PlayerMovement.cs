using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 100;
    public Rigidbody2D rb;

    public void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 newVect = new Vector3(h, v, 0);
        newVect = newVect.normalized * speed * Time.deltaTime;
        rb.MovePosition(rb.transform.position + newVect);
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    
}
