using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{

    public Vector3 originalPos;
    private gamemaster gm;

    private void Awake()
    {
       originalPos = gameObject.transform.position;

    }
    private void OnCollisionEnter2D (Collision2D other)
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<gamemaster>();

        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("TESTER");
          //  gameObject.transform.position = originalPos;
            transform.position = gm.LastCheckpointPos;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
