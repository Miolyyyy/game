using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public int playerHealth;
    public int score;
    public static bool gameOver;
    public TextMeshProUGUI playerHealthText;
    public TextMeshProUGUI playerScoreText;
    public GameObject imageGameOver;
    public GameObject imageRedScreen;
    public float lifetime = 3;

    void Start()
    {
        gameOver = false;
        playerHealth = 5;
        score = 0;
    }

    void Update()
    {
        playerHealthText.text = "" + playerHealth;

        if (gameOver == true)
            {
                imageGameOver.SetActive(true);

                SceneManager.LoadScene("Menu");
            }
    }

    //void OnTriggerStay(Collider telo)
    //{//если тело
    //    if (telo.CompareTag("enemy"){//с тегом enemy находится в зоне триггера(тот о котором я выше сказал)

    //        health -= damage);//отнять хп

    //    }
    public void TakeDamagePlayer(int damageEnemy)
    {
        playerHealth -= damageEnemy;

        if (playerHealth <= 0)
        {
            gameOver = true;

        }
    }

}
