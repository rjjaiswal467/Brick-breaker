using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{

    [SerializeField] int breakableblock;
    SceneLoader sceneLoader;
    //[SerializeField] int points = 0;

    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }
    public void CountBlock()
    {
        breakableblock++;
    }

    

    public void BlockDestroyed()
    {
        breakableblock--;
       // points = points + 1;
        if (breakableblock <= 0)
        {
            sceneLoader.LoadNextScene();
        }
    }
}
