using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{

    public Vector3 originalPos;
    
    private void Awake()
    {
       originalPos = gameObject.transform.position;

    }
    private void OnCollisionEnter2D (Collision2D other)
    {
      

        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("TESTER");
          //  gameObject.transform.position = originalPos;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
