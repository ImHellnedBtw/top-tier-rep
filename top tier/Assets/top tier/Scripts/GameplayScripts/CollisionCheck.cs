using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionCheck : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI scoreText;
    private int score;
    private IDoable doable;
    private void Start()
    {
        doable = BackgroundOperation.backgroundOperator.GetComponent<IDoable>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Coin"))
        {
            score++;
            scoreText.text = "Score: " +score.ToString();
            doable.Use(3);
            Destroy(collision.gameObject);
            return;
        }else
        if(collision.gameObject.CompareTag("Barrier"))
        {
            GameOver();
        }
    }
    void GameOver()
    {
        InformationController.LastScore = score;
        if (score > InformationController.BestScore)
            InformationController.BestScore = score;
        PlayerPrefs.SetInt("LastScore", InformationController.LastScore);
        PlayerPrefs.SetInt("BestScore", InformationController.BestScore = score);
        SceneManager.LoadScene("GameOverScene");
    }
}
