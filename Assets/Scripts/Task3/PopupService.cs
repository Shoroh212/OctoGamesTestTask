using UnityEngine;

public class PopupService : MonoBehaviour, IPopupService
{
    [SerializeField] private PopupView popupPrefab;

    [SerializeField] private Transform popupRoot;

    private PopupView currentPopup;


    public void Show(PopupData data)
    {
        Hide();



        currentPopup = Instantiate(
            popupPrefab,
            popupRoot);

        currentPopup.Initialize(data);
        Debug.Log("попап показан");
    }

    public void Hide()
    {
        

        Destroy(currentPopup.gameObject);
        Debug.LogError("Текущий попап уничтожен");

        currentPopup = null;
    }
}