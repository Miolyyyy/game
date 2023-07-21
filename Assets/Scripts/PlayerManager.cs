using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public static int playerHealth;
    public static bool gameOver;
    public TextMeshProUGUI playerHealthText;
    public GameObject imageGameOver;
    public GameObject imageRedScreen;
    public float lifetime=3;


    void Start()
    {
        playerHealth = 0;
        gameOver = false;
    }

    void Update()
    {
        playerHealthText.text = "" + playerHealth;

        
    }

    public IEnumerator Damage (int damageCount)
    {
        playerHealth -= damageCount;
        imageRedScreen.SetActive(true);

        if (playerHealth <= 0)
        {
            gameOver = true;
            if (gameOver)
            {
                if (lifetime <= 0)
                {
                    imageRedScreen.SetActive(false);
                }
                else
                {
                    lifetime -= Time.deltaTime;
                    imageGameOver.SetActive(true);
                }
                SceneManager.LoadScene("Menu");
            }
        }

        yield return new WaitForSeconds(.5f);
        imageRedScreen.SetActive(false);
    }
}
