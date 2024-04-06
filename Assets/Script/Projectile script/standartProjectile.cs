using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class standartProjectile : MonoBehaviour
{
    [SerializeField] float lifetime = 0.1f;
    [SerializeField] int damage = 25;
    public float speed = 20f;



    void Awake() {
        Destroy(gameObject, lifetime);
    }

    private void OnTriggerEnter2D(Collider2D hitInfo) {
        

        if(hitInfo.gameObject.CompareTag("ExplodingInsect"))
        {
            ExplodingIncesct enemy = hitInfo.GetComponent<ExplodingIncesct>();
            if (enemy != null)
            {

                print("BUG HIT!");
                enemy.TakeDamage(damage);
            }
            Destroy(gameObject);
            
        }

        
    }
}
