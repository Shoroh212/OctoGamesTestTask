using System;
using System.IO;
using UnityEngine;

public static class SaveSystem
{
    private static readonly string SavePath = Application.persistentDataPath + "/save.json";

    public static void Save<T>(T data)
    {
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(SavePath, json);
    }

    public static T Load<T>() where T : new()
    {
        if (!File.Exists(SavePath))
            return new T();

        try
        {
            string json = File.ReadAllText(SavePath);
            return JsonUtility.FromJson<T>(json);
        }
        catch
        {
            return new T();
        }
    }
}