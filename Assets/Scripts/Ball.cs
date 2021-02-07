using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle1;
    [SerializeField] float xPush = 2f;
    [SerializeField] float yPush = 10f;
    [SerializeField] float randomFactor = 0.2f;
    int check = 1;

    Vector2 paddleToBallVector;
    bool hasStarted = false;

    Rigidbody2D myrigidbody2D;
    void Start()
    {
        paddleToBallVector = transform.position - paddle1.transform.position;
        myrigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            LockBallToPaddle();
            LaunchOnMouseClick();
        }
        
    }

    public void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
       // if (Input.GetKeyDown("space"))
        {
            myrigidbody2D.velocity = new Vector2(xPush, yPush);
            hasStarted = true;
        }
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlepos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlepos + paddleToBallVector;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 velocityTweak = new Vector2(Random.Range(0f,randomFactor), Random.Range(0f, randomFactor));
        if (hasStarted && collision.gameObject.name!="Paddle")
        {
            GetComponent<AudioSource>().Play();
            //Debug.Log(collision.gameObject.name);
            check++;

        }
        if (hasStarted)
        {
            myrigidbody2D.velocity += velocityTweak;
            /*Debug.LogError(myrigidbody2D.velocity);*/
        }
    }

    public int StartCheck()
    {
        return check;
    }

}
