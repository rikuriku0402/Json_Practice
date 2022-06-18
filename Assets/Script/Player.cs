using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JsonData;

[System.Serializable]
public class Player:MonoBehaviour
{
    public int hp = 100;
    public int attack = 20;
    public int defense = 5;
    void Start()
    {
        //Debug.Log(JsonUtility.ToJson(this));
        JsonDataClass jsonDataClass;

        string jsonString = "{\"HP\":12,\"ATK\":6,\"name\":\"asdf\"}";
        jsonDataClass = JsonUtility.FromJson<JsonDataClass>(jsonString);

        Debug.Log(jsonDataClass.ATK);
        Debug.Log(jsonDataClass.name);
        Debug.Log(jsonDataClass.HP);
    }
}
