using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerState : MonoBehaviour
{
    //Coded by Mark Beveridge
    // stores the data to be exported to saves.
    public int currentLevel = 1;
    public float[] playerCheckpoint;

    public PlayerState(Player player)
    {
        currentLevel = player.level;
        playerCheckpoint = new float[3];
        playerCheckpoint[0] = player.transform.position.x;
        playerCheckpoint[1] = player.transform.position.y;
        playerCheckpoint[2] = player.transform.position.z;

    }

}

