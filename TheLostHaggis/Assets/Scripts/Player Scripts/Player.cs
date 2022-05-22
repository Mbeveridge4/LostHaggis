using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int level;
    public Vector3 currentPosition;
    public Rigidbody2D RigidBody;

  


    void Update()
    {
    
    }

    public void SavePlayer()
    {
        SaveGame.SaveData(this);

    }
    public void LoadPlayer()
    {
        PlayerState data = SaveGame.LoadPlayer();

        level = data.currentLevel;

        currentPosition.x = data.playerCheckpoint[0];
        currentPosition.x = data.playerCheckpoint[1];
        currentPosition.x = data.playerCheckpoint[2];
        transform.position = currentPosition;
    }
}
