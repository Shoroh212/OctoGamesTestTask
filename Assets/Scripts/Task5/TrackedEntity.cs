using UnityEngine;

public class TrackedEntity : MonoBehaviour
{
    private void OnEnable()
    {
        Statstracker.Register(this);
    }

    private void OnDisable()
    {
        Statstracker.Unregister(this);
    }
}