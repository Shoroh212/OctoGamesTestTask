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
    }

    public void Hide()
    {
        

        Destroy(currentPopup.gameObject);

        currentPopup = null;
    }
}