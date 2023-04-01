using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIRacket : MonoBehaviour
{
    public float speedTwo = 30;
    public string axis = "Vertical";

    public bool twoPlayer = false;
    public GameObject ball;
    public float speedOne = 30;

    void Update()
    {
        if(twoPlayer == true)
        {
            float v = Input.GetAxisRaw(axis);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speedTwo;
        }

        if(twoPlayer == false)
        {
            if(ball.transform.position.y > this.transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * speedOne;
            }

            if(ball.transform.position.y < this.transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * speedOne;
            }
        }
    }
}
