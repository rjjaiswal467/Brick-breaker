using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currenSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currenSceneIndex+1);
    }

    public void LoadStartScene()
    {
        FindObjectOfType<GameSession>().ResetScore();
        SceneManager.LoadScene(0);
        
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }

    public void LoadLevel1()
    {
        int currentSceneIndex1 = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("Level 1");
    }
    public void LoadLevel2()
    {
        int currentSceneIndex1 = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("Level 2");
    }
    public void LoadLevel3()
    {
        int currentSceneIndex1 = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("Level 3");
    }
    public void LoadLevel4()
    {
        int currentSceneIndex1 = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("Level 4");
    }
}
