using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupView : MonoBehaviour
{
    [SerializeField]private TMP_Text title;

    [SerializeField] private TMP_Text message;

    [SerializeField] private Button buttonPrefab;

    [SerializeField] private Transform buttonContainer;

    public void Initialize(PopupData data)
    {
        title.text = data.Title;
        message.text = data.Message;

        foreach (Transform child in buttonContainer)
            Destroy(child.gameObject);

        foreach (PopupButtonData buttonData in data.Buttons)
        {
            Button button =
                Instantiate(buttonPrefab, buttonContainer); // Небольшая нагрузка для GC , но в рамках ТЗ это не критично 

            button.GetComponentInChildren<TMP_Text>().text =
                buttonData.Text;

            button.onClick.AddListener(() =>
            {
                buttonData.Callback?.Invoke();
                Destroy(gameObject);
            });
        }
    }
}