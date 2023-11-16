using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerTwoGoal : MonoBehaviour
{
    private bool isColliding;
    public GameObject player1Text;
    public GameObject ball;
    private int _playerOneScore = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        _playerOneScore++;
        player1Text.GetComponent<TextMeshProUGUI>().text = _playerOneScore.ToString();
        ball.GetComponent<Ball>().Reset();
        ball.GetComponent<Ball>().Launch();
    }

}
