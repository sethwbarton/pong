using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerOneGoal : MonoBehaviour
{
    public GameObject playerTwoText;
    public GameObject ball;
    private int _playerTwoScore = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        _playerTwoScore++;
        playerTwoText.GetComponent<TextMeshProUGUI>().text = _playerTwoScore.ToString();
        ball.GetComponent<Ball>().Reset();
        ball.GetComponent<Ball>().Launch();
    }

}