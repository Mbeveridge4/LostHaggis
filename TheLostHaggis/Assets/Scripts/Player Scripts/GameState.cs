using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameState : MonoBehaviour
{
    //Coded by Mark Beveridge
    public int currentLevel = 1;
    public float[] playerCheckpoint;

    public GameState (Player player)
    {
        currentLevel = player.level;
        playerCheckpoint = new float[1];
        playerCheckpoint[0] = player.transform.position.x;
        playerCheckpoint[1] = player.transform.position.y;
        
    }
}
