using TMPro;
using UnityEngine;

public class PlayerOneGoal : MonoBehaviour
{
    public GameObject playerTwoText;
    public GameObject ball;
    private int _playerTwoScore;

    private void OnTriggerEnter2D(Collider2D other)
    {
        _playerTwoScore++;
        playerTwoText.GetComponent<TextMeshProUGUI>().text = _playerTwoScore.ToString();
        ball.GetComponent<Ball>().Reset();
        ball.GetComponent<Ball>().Launch();
    }
}