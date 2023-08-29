using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    public GameObject ball;
    public GameObject player1;
    public GameObject player1Goal;
    public GameObject player2;
    public GameObject player2Goal;
    public Text player1Text;
    public Text player2Text;



    private int player1Socore;
    private int player2Socore;


    public void player1Socored()
    {
        player1Socore++;
        player1Text.text = player1Socore.ToString();
        ResetPosition();
    }

    public void player2Socored()
    {
        player2Socore++;
        player2Text.text = player2Socore.ToString();
        ResetPosition();
    }
    public void ResetPosition()
    {
        ball.GetComponent<Bol>().Reset();
        player1.GetComponent<Players>().Reset();
        player2.GetComponent<Players>().Reset();
    }
}
