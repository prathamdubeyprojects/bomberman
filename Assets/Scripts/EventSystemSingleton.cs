using UnityEngine;
using UnityEngine.EventSystems;

public class EventSystemSingleton : MonoBehaviour
{
    private static EventSystemSingleton instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Make the EventSystem persist across scenes
        }
        else if (instance != this)
        {
            Destroy(gameObject); // Destroy any duplicate instances
        }
    }
}
