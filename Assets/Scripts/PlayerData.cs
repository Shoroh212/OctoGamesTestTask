
using System;

[Serializable]
public class PlayerData
{
    public int coins; 
    public int level;
}

public interface ISaveSystem
{
    void Save<T>(T data);
    T Load<T>() where T : new();
}