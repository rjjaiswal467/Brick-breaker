using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSession : MonoBehaviour
{

    [Range(1f,2f)][SerializeField] float gamespeed = 1f;
    [SerializeField] int currentScore = 0;
    [SerializeField] int pointPerBlockDestroyed = 83;
    [SerializeField] TextMeshProUGUI scoreText;

    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameSession>().Length; //implement singleton.
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        scoreText.text = currentScore.ToString();
    }

    void Update()
    {
        Time.timeScale = gamespeed;
    }

    public void ResetScore()
    {
        Destroy(gameObject);
    }

    public void AddToScore()
    {
        currentScore = currentScore + pointPerBlockDestroyed;
        scoreText.text = currentScore.ToString();
    }
}
