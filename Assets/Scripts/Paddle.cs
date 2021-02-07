using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits;
    [SerializeField] float minX;
    [SerializeField] float maxX;
    Ball ball;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Debug.Log(Screen.width);
        Vector2 paddlepos = new Vector2(transform.position.x, transform.position.y);
        paddlepos.x = Mathf.Clamp(mousePosInUnits, minX, maxX);
        transform.position = paddlepos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        ball = FindObjectOfType<Ball>();
        if (ball.StartCheck() > 1) 
        {
            GetComponent<AudioSource>().Play();
          // Debug.Log(collision.gameObject.name);
        }
        
        

    }
}
