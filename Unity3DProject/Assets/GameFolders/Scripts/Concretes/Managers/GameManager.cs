using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public event System.Action OnGameOver;

    public event System.Action OnMissionSucced;

    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        SinglationThisGameObject();
    }

    private void SinglationThisGameObject()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    } 

    public void GameOver()
    {
        OnGameOver?.Invoke();
    }

    public void MissionSucced()
    {
        OnMissionSucced?.Invoke();
    }

    public void LoadLevelScene(int levelIndex = 0)
    {
        StartCoroutine(LoadLevelSceneAsync(levelIndex));
    }
        
    private IEnumerator LoadLevelSceneAsync(int levelIndex)
    {
       yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelIndex);
    }

    public void LoadMenu()
    {
        StartCoroutine(LoadMenuSceneAsync());
    }

    private IEnumerator LoadMenuSceneAsync()
    {
        yield return SceneManager.LoadSceneAsync("Menu");
    }

    public void Exit()
    {
        Debug.Log("EXIT");
        Application.Quit();
    }
}
