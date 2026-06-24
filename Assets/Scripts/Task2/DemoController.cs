using UnityEngine.UIElements;
using UnityEngine;
using TMPro;




// Использование системы сохранения 


public class DemoController : MonoBehaviour
{
    [SerializeField] private TMP_InputField coinsInput;
    [SerializeField] private TMP_InputField levelInput;

    private ISaveSystem saveService;
    private PlayerData playerData; // зависимость от модели данных

    private void Awake()
    {
        saveService = new JsonSaveService();
    }

    private void Start()
    {
        playerData = saveService.Load<PlayerData>();

        coinsInput.text = playerData.coins.ToString();
        levelInput.text = playerData.level.ToString();
    }

    public void Save()
    {
        PlayerData data = new PlayerData
        {
            coins = int.Parse(coinsInput.text),
            level = int.Parse(levelInput.text)
        };

        saveService.Save(data);
    }

    public void Load()
    {
        PlayerData data = saveService.Load<PlayerData>();

        coinsInput.text = data.coins.ToString();
        levelInput.text = data.level.ToString();
    }

}