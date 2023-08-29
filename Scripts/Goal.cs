using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    public bool player1Goal;
    public GameObject gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            if (player1Goal)
            {
                gameManager.GetComponent<GameManager>().player1Socored();
            }
            else
            {
                gameManager.GetComponent<GameManager>().player2Socored();

            }
        }
    }
}
