using System.Collections.Generic;
using UnityEngine;
public class Statstracker : MonoBehaviour
{
    private static readonly HashSet<TrackedEntity> entities =
        new HashSet<TrackedEntity>();

    public static void Register(TrackedEntity entity)
    {
        if (entity == null)
            return;

        entities.Add(entity);
    }

    public static void Unregister(TrackedEntity entity)
    {
        if (entity == null)
            return;

        entities.Remove(entity);
    }

    public static IReadOnlyCollection<TrackedEntity> GetActive()
    {
        return entities;
    }
}

/* использование 
 * 
 * 
 *   Debug.Log(entity.name);
 * 
 * 
 * 
 * 
 * 
 */
