using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        PlayerPrefs.SetString("_last_scene_", scene.name);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int currenSceneIndex = SceneManager.GetActiveScene().buildIndex;
        
        SceneManager.LoadScene("Game over");
        //SceneManager.LoadScene(PlayerPrefs.GetInt("Level 4"));

    }

    
}
