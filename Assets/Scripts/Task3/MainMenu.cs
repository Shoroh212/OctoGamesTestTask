using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private PopupService popupService;

    public void Exit()
    {
        PopupData popup = new PopupData
        {
            Title = "Выход",
            Message = "Вы действительно хотите выйти?"
        };

        popup.Buttons.Add(
            new PopupButtonData(
                "Да",
                () => Application.Quit()));

        popup.Buttons.Add(
            new PopupButtonData(
                "Нет",
                () => popupService.Hide()));

        popupService.Show(popup);
    }
}