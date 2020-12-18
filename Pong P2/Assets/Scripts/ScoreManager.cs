using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text player1;
    public Text player1Title;
    private int scoreP1;
    public Text player2;
    public Text player2Title;
    private int scoreP2;

    public GameObject powerUp1;
    public GameObject powerUp2;
    // Start is called before the first frame update
    void Start()
    {
        scoreP1 = 0;
        scoreP2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreP1 == 10 && scoreP2 == 10)
        {
            player1.color = Color.yellow;
            player2.color = Color.yellow;
            player1Title.color = Color.yellow;
            player2Title.color = Color.yellow;
        }
        else if (scoreP1 == 10)
        {
            player2.color = Color.red;
            player2Title.color = Color.red;
        }
        else if (scoreP2 == 10)
        {
            player1.color = Color.red;
            player1Title.color = Color.red;
        }
    }

    public void Scored(bool player)
    {
        if (!player)
        {
            scoreP1++;
            player1.text = "" + scoreP1;
            if (scoreP1 >= 11)
            {
                GameWin("Player 1");
            }
            else
            {
                Debug.Log("Player 1 Scored\n" + "Score is " + scoreP1 + "-" + scoreP2);
            }
        }
        if (player)
        {
            scoreP2++;
            player2.text = "" + scoreP2;
            if (scoreP2 >= 11)
            {
                GameWin("Player 2");
            }
            else
            {
                Debug.Log("Player 2 Scored\n" + "Score is " + scoreP1 + "-" + scoreP2);
            }
        }
    }

    void GameWin(string winner)
    {
        Debug.Log(winner + " Won!");
        scoreP1 = 0;
        scoreP2 = 0;
        player1.text = "00";
        player2.text = "00";
        player1.color = Color.white;
        player2.color = Color.white;
        player1Title.color = Color.white;
        player2Title.color = Color.white;
        powerUp1.SetActive(true);
        powerUp2.SetActive(false);
    }
}
