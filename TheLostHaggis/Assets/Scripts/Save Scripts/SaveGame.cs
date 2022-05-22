using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// system.io is used to allow us to deal with external files
using System.IO;
//binary formatter to save the data in a binary format so it can't be edited externally
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveGame
{
    //coded by Mark Beveridge


    //Saves the data from PlayerState to an external file in a binary format
    public static void SaveData (Player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        //uses unity's inbuilt function to find a persistant path, and saves it under save.data
        string path = Application.persistentDataPath + "/save.data";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerState data = new PlayerState(player);
        formatter.Serialize(stream, data);
        stream.Close();
    }


    //loads the data from the external file converting it back from a binary format
    public static PlayerState LoadPlayer ()
    {
        string path = Application.persistentDataPath + "/save.data";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            PlayerState data = formatter.Deserialize(stream) as PlayerState;

            stream.Close();

            return data;

        }
        else
        {
            Debug.LogError("Save file not found in " + path);
                return null;
        }
    }
}
