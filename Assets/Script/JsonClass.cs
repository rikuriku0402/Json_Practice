using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonClass : MonoBehaviour
{
    public int HP = 1;
    public int ATK = 3;
    public string name = "hello";

    void Start()
    {
        string jsonString = "{\"HP\":12,\"ATK\":6,\"name\":\"asdf\"}";
        JsonUtility.FromJsonOverwrite(jsonString, this);
        Debug.Log(this.ATK);
        Debug.Log(this.name);
        Debug.Log(this.HP);
    }

    void Update()
    {
        
    }
}
