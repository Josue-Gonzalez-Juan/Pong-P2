using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float moveSpeed;
    public float player1Input;
    public float player2Input;

    public Transform player1Paddle;
    public Transform player2Paddle;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 8;
    }

    // Update is called once per frame
    void Update()
    {
        player1Input = Input.GetAxis("Player1Vertical");
        player2Input = Input.GetAxis("Player2Vertical");

        player1Paddle.Translate(new Vector3(0, 0, player1Input) * moveSpeed * Time.deltaTime);
        player2Paddle.Translate(new Vector3(0, 0, player2Input) * moveSpeed * Time.deltaTime);
    }
}
