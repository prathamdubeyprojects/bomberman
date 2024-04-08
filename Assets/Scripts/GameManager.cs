using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public GameObject[] players;

    // private void Awake()
    // {
    //     if (Instance != null) {
    //         DestroyImmediate(gameObject);
    //     } else {
    //         Instance = this;
    //         DontDestroyOnLoad(gameObject);
    //     }
    // }

private void Awake()
{
    if (Instance != null) {
        DestroyImmediate(gameObject);
    } else {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
}

private void OnDestroy()
{
    // Remember to unsubscribe to avoid memory leaks
    SceneManager.sceneLoaded -= OnSceneLoaded;
}

private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
{
    // Update the players array here, for example by finding all objects of a certain tag
    players = GameObject.FindGameObjectsWithTag("Player");
}

    // public void CheckWinState()
    // {
    //     int aliveCount = 0;

    //     foreach (GameObject player in players)
    //     {
    //         if (player.activeSelf) {
    //             aliveCount++;
    //         }
    //     }

    //     if (aliveCount <= 1) {
    //         Invoke(nameof(NewRound), 3f);
    //     }
    // }

public void CheckWinState()
{
    int aliveCount = 0;

    foreach (GameObject player in players)
    {
        if (player.activeSelf) {
            aliveCount++;
        }
    }

    Debug.Log("Alive players: " + aliveCount);

    if (aliveCount <= 1) {
        Invoke(nameof(NewRound), 3f);
    }
}
    private void NewRound()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
