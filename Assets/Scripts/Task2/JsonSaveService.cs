using System.IO;
using UnityEngine;

public class JsonSaveService : ISaveSystem
{
    private readonly string savePath =
        Application.persistentDataPath + "/save.json";

    public void Save<T>(T data)
    {
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(savePath, json);
    }

    public T Load<T>() where T : new()
    {
        if (!File.Exists(savePath))
            return new T();

        try
        {
            string json = File.ReadAllText(savePath);
            return JsonUtility.FromJson<T>(json);
        }
        catch
        {
            return new T();
        }
    }
}