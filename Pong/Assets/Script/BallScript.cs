using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    public float speed = 67;
    public int pointsRight = 0;
    public int pointsLeft = 0;

    void Update()
    {
        if (speed > 70)
            speed = 69;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "LeftRacket")
        {           
            float y = hitFactor(transform.position, 
                col.transform.position, 
                col.collider.bounds.size.y);

            Vector2 dir = new Vector2(1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
            speed = speed + 1;
        }

        if(col.gameObject.name == "RightRacket")
        {
            float y = hitFactor(transform.position,
                col.transform.position,
                col.collider.bounds.size.y);
            Vector2 dir = new Vector2(-1, y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
            speed = speed + 1;
        }

        float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHaight)
        {
            return (ballPos.y - racketPos.y) / racketHaight;
        }

        if(col.gameObject.name == "RightWall")
        {
            pointsLeft = pointsLeft + 1;
        }

        if(col.gameObject.name == "LeftWall")
        {
            pointsRight = pointsRight + 1;
        }
    }

}
