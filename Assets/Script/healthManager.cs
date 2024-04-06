using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class healthManager : MonoBehaviour
{
    public GameObject gameOverScreen;
    public Image healthBar;
    public GameObject unfortunateVictim;
    public float maxHealthAmount = 100;
    public float currentHealthAmount = 100;

    public void Start() {

        currentHealthAmount = maxHealthAmount;

        unfortunateVictim = GameObject.Find("Tirador");

        gameOverScreen.SetActive(false);
    }

    public void Update()
    {
        healthBar.fillAmount = currentHealthAmount / 100f;
    }

    public float healthBarVizualizers
    {
        get
        {
            return currentHealthAmount / maxHealthAmount;
        }
    }

    public void  TakeDamage(int enemyDamage)
    {

        healthBar.fillAmount = currentHealthAmount / 100f ;

        if (currentHealthAmount == 0)
        {
            Destroy(gameObject);
            Destroy(unfortunateVictim);
            gameOverScreen.SetActive(true);
            Time.timeScale = 1;

            return;
        }
        
        currentHealthAmount -= enemyDamage;

        if (currentHealthAmount < 0)
        {
            currentHealthAmount = 0;
        }

    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
