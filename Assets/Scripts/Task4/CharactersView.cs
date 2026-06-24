using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class CharactersView : MonoBehaviour
{
    [SerializeField] private List<Transform> _characters;
    [SerializeField] private Text _text;
    float totalValue = 0f;
    int charactersCount = 0;
    [SerializeField] private float _updateInterval = 0.5f;
    private float _timer;
    private void FixedUpdate()
    {
        _timer += Time.fixedDeltaTime;

        if (_timer < _updateInterval)
            return;

        _timer = 0f;

        UpdateView();
    }

    private void UpdateView()
    {

        totalValue = 0f;
        charactersCount = 0;

        foreach (Transform characterTransform in _characters)
        {
            if (characterTransform == null)
                continue;

            Character character = characterTransform.GetComponent<Character>();   // убрал лишний блок кода, который был в оригинале

            if (character == null)
                continue;

            totalValue += character.Value;
            charactersCount++;
        }

        float averageValue = charactersCount > 0
            ? totalValue / charactersCount
            : 0f;
        string text = string.Format(
            "Characters: {0} Avg value: {1:F2}",
            charactersCount,
            averageValue
        );
        _text.text = text;     // плохая идея обновлять каждый фикс.кадр и выводить в консоль, но в рамках ТЗ не указанно что именно хотел сделать автор
        Debug.Log(text);     //но в рамках ТЗ не указанно что именно хотел сделать автор
    }
}
