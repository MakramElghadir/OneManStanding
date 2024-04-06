using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingIncesct : MonoBehaviour
{
    [SerializeField] int health= 150;
    public int speed = 10;

    // Start is called before the first frame update
    public void TakeDamage(int damage)
    {
        health -= damage;
        
        if (health <= 0)
        {
            Die();
            print("THE BUG IS DEAD!");
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

}
