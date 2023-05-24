using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    public bool canShoot;
    public float powerUpDuration = 5;
    float powerUpTimer = 0;


    public Text coinText;
    int coins;

    public void AddCoin()
    {
        coins++;
        coinText.text = coins.ToString();
    }

    public List<GameObject> enemiesInScreen = new List<GameObject>();

    void Start()
    {
        
    }

    void Update()
    {
        ShootPowerUp();

        if(Input.GetKeyDown(KeyCode.P))
        {
            KillAllEnemies();
        }
    }

    public void GameOver()
    {
        isGameOver = true;

        StartCoroutine("LoadScene");
    }

    void ShootPowerUp()
    {
        if(canShoot)
    {
       if (powerUpTimer <= powerUpDuration)
        {
            powerUpTimer += Time.deltaTime;
        } 

        else 
        {
            canShoot = false;
            powerUpTimer = 0;
        }
        
     }
    }

    void KillAllEnemies()
    {
        for (int i = 0; i < enemiesInScreen.Count; i++)
        {
            Destroy(enemiesInScreen[i]);
        }
    }
}
