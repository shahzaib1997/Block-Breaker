using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // configuration parameters
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    float mousePosInUnits;
    float deltaXPos = 0.01f;

    // cached component refrences
    GameStatus gameStatus;
    Ball ball;
    Rigidbody2D myRigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        gameStatus = FindObjectOfType<GameStatus>();
        ball = FindObjectOfType<Ball>();
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameStatus.IsAutoPlayEnabled())
        {
            //mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
            Vector3 paddlePos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            paddlePos.x = Mathf.Clamp(GetXPos(), minX, maxX);
            transform.position = paddlePos;
        }
        ControlPaddle();
    }

    private void ControlPaddle()
    {
        if(transform.position.x <= 1f || transform.position.x >= 15f)
        {
            myRigidbody2D.velocity = new Vector2(0f, 0f);
            if (transform.position.x <= 1f)
            {
                float getXPos = transform.position.x;
                Vector3 paddlePos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                paddlePos.x = Mathf.Clamp(getXPos + deltaXPos, minX, maxX);
                transform.position = paddlePos;
            }
            else if (transform.position.x >= 15f)
            {
                float getXPos = transform.position.x;
                Vector3 paddlePos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                paddlePos.x = Mathf.Clamp(getXPos - deltaXPos, minX, maxX);
                transform.position = paddlePos;
            }
        }
    }

    private float GetXPos()
    {
        return ball.transform.position.x;
    }

    public void ButtonSetPaddlePositionRight()
    {
        /*float getXPos = transform.position.x;
        Vector3 paddlePos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        paddlePos.x = Mathf.Clamp(++getXPos, minX, maxX);
        transform.position = paddlePos;*/

        myRigidbody2D.velocity = new Vector2(20f, 0);
    }

    public void ButtonSetPaddlePositionLeft()
    {
        /*float getXPos = transform.position.x;
        Vector3 paddlePos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        paddlePos.x = Mathf.Clamp(--getXPos, minX, maxX);
        transform.position = paddlePos;*/

        myRigidbody2D.velocity = new Vector2(-20f, 0);
    }
}
