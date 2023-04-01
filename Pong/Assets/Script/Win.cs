using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public BallScript ballScript;
    public AIRacket ai;

    public Text showR;
    public Text shoeL;
    public Text win;
    public Text dif;
    public GameObject buttonEasy;
    public GameObject buttonMedium;
    public GameObject buttonHard;
    public GameObject buttonTwo;
    public GameObject buttonP;
    public GameObject buttonPL;

    public GameObject circle;
    public GameObject rightRacket;
    public GameObject leftRacket;

    void Start()
    {
        Time.timeScale = 0;
        win.text = ("PONG");
        dif.text = ("Select Difficulty");
        buttonP.SetActive(false);
        buttonPL.SetActive(false);
    }

    void Update()
    {
        showR.text = ("Points: " + ballScript.pointsRight);
        shoeL.text = ("Points: " + ballScript.pointsLeft);

        if(ballScript.pointsRight == 10)
        {
            win.text = ("Right Side has WON");
            dif.text = ("Select Difficulty");
            Time.timeScale = 0;
            buttonEasy.SetActive(true);
            buttonMedium.SetActive(true);
            buttonHard.SetActive(true);
            buttonTwo.SetActive(true);
            buttonP.SetActive(false);
            buttonPL.SetActive(false);
        }
        if (ballScript.pointsLeft == 10)
        {
            win.text = ("Left Side has WON");
            dif.text = ("Select Difficulty");
            Time.timeScale = 0;
            buttonEasy.SetActive(true);
            buttonMedium.SetActive(true);
            buttonHard.SetActive(true);
            buttonTwo.SetActive(true);
            buttonP.SetActive(false);
            buttonPL.SetActive(false);
        }
    }

    public void Easy()
    {
        ai.speedOne = 20;
        ballScript.pointsRight = 0;
        ballScript.pointsLeft = 0;
        ballScript.speed = 30;
        win.text = ("");
        dif.text = ("");
        Time.timeScale = 1;
        buttonEasy.SetActive(false);
        buttonMedium.SetActive(false);
        buttonHard.SetActive(false);
        buttonTwo.SetActive(false);
        buttonP.SetActive(true);
        buttonPL.SetActive(true);
        circle.transform.position = new Vector3(0, 0, 0);
        circle.GetComponent<Rigidbody2D>().velocity = Vector2.right * 30;
        rightRacket.transform.position = new Vector3(20, 0, 0);
        leftRacket.transform.position = new Vector3(-20, 0, 0);
    }

    public void Medium()
    {
        ai.speedOne = 40;
        ballScript.pointsRight = 0;
        ballScript.pointsLeft = 0;
        ballScript.speed = 30;
        win.text = ("");
        dif.text = ("");
        Time.timeScale = 1;
        buttonEasy.SetActive(false);
        buttonMedium.SetActive(false);
        buttonHard.SetActive(false);
        buttonTwo.SetActive(false);
        buttonP.SetActive(true);
        buttonPL.SetActive(true);
        circle.transform.position = new Vector3(0, 0, 0);
        circle.GetComponent<Rigidbody2D>().velocity = Vector2.right * 30;
        rightRacket.transform.position = new Vector3(20, 0, 0);
        leftRacket.transform.position = new Vector3(-20, 0, 0);
    }

    public void Hard()
    {
        ai.speedOne = 60;
        ballScript.pointsRight = 0;
        ballScript.pointsLeft = 0;
        ballScript.speed = 30;
        win.text = ("");
        dif.text = ("");
        Time.timeScale = 1;
        buttonEasy.SetActive(false);
        buttonMedium.SetActive(false);
        buttonHard.SetActive(false);
        buttonTwo.SetActive(false);
        buttonP.SetActive(true);
        buttonPL.SetActive(true);
        circle.transform.position = new Vector3(0, 0, 0);
        circle.GetComponent<Rigidbody2D>().velocity = Vector2.right * 30;
        rightRacket.transform.position = new Vector3(20, 0, 0);
        leftRacket.transform.position = new Vector3(-20, 0, 0);
    }

    public void TwoPlayer()
    {
        ai.twoPlayer = true;
        ballScript.pointsRight = 0;
        ballScript.pointsLeft = 0;
        ballScript.speed = 30;
        win.text = ("");
        dif.text = ("");
        Time.timeScale = 1;
        buttonEasy.SetActive(false);
        buttonMedium.SetActive(false);
        buttonHard.SetActive(false);
        buttonTwo.SetActive(false);
        buttonP.SetActive(true);
        buttonPL.SetActive(true);
        circle.transform.position = new Vector3(0, 0, 0);
        circle.GetComponent<Rigidbody2D>().velocity = Vector2.right * 30;
        rightRacket.transform.position = new Vector3(20, 0, 0);
        leftRacket.transform.position = new Vector3(-20, 0, 0);
    }

    public void Pause()
    { 
        Time.timeScale = 0;
    }

    public void Play2()
    {
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
