using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingInsectAttack : MonoBehaviour
{
    public int enemyDamage = 10;

    public void Start()
    {
       
    }



    public void OnTriggerEnter2D(Collider2D hitInfo)
    {


        if (hitInfo.gameObject.CompareTag("Player"))
        {
            healthManager enemy = hitInfo.GetComponent<healthManager>();
            if (enemy != null)
            {

                print("YOU'RE DAMAGED!");
                enemy.TakeDamage(enemyDamage);
            }
            Destroy(gameObject);

        }


    }

}
