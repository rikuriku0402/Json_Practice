using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;


[Serializable]
public struct SaveData
{
    public int x;
    public int y;

    public void Dump()
    {
        Debug.Log("x = " + x);
        Debug.Log("y = " + y);
    }
}

public class SaveManager : MonoBehaviour
{
    const string SAVE_FILE_PATH = "save.txt";
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            var data = new SaveData();
            data.x = 5;
            data.y = 7;

            var json = JsonUtility.ToJson(data);

            var path = Application.dataPath + "/" + SAVE_FILE_PATH;
            var writer = new StreamWriter(path, false);
            writer.WriteLine(json);
            writer.Flush();
            writer.Close();
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            var info = new FileInfo(Application.dataPath + "/" + SAVE_FILE_PATH);
            var reader = new StreamReader(info.OpenRead());
            var json = reader.ReadToEnd();
            var data = JsonUtility.FromJson<SaveData>(json);
            data.Dump();
        }
    }
}
