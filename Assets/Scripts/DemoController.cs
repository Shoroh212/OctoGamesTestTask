using UnityEngine.UIElements;
using UnityEngine;
using TMPro;




// Использование системы сохранения 


public class DemoController : MonoBehaviour
{
    [SerializeField] private TMP_InputField coinsInput;
    [SerializeField] private TMP_InputField levelInput;

    private PlayerData playerData;

    private void Start()
    {
        playerData = SaveSystem.Load<PlayerData>();

        coinsInput.text = playerData.coins.ToString();
        levelInput.text = playerData.level.ToString();
    }

    public void Save()
    {
        playerData.coins = int.Parse(coinsInput.text);
        playerData.level = int.Parse(levelInput.text);

        SaveSystem.Save(playerData);
    }

    public void Load()
    {
        playerData = SaveSystem.Load<PlayerData>();



        coinsInput.text = playerData.coins.ToString();
        levelInput.text = playerData.level.ToString();
    }

    
}