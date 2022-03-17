using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Database : MonoBehaviour
{
    private string path = Application.dataPath + "/Recources/Saves";
    public void SaveData<T>(string saveName, T saveData)
    {
        string JsonToSave = JsonUtility.ToJson(saveData);
        File.WriteAllText
            (
            path + saveName + ".json",
            JsonToSave
            );
    }

    public void LoadData<T>(string saveName, System.Action<T> callback)
    {
        if (File.Exists(path + saveName + ".json"))
        {
            string loadedJson = File.ReadAllText(path + saveName + ".json");
            callback(JsonUtility.FromJson<T>(loadedJson));
        }else
        {
            Debug.Log("File does not exist");
        }
    }
}
