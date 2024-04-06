using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : BaseAbility
{
    public GameObject projectilePrefab;
    public Transform firepoint;

    public float cooldown;
    public float targetTime;
    public Image cooldownImage;

    public bool cooldowner => Time.time < targetTime;
    public void cooldownStarter() => targetTime = Time.time + cooldown;



    public override void Trigger() {
        // aquí el código de disparar
        


        if (cooldowner) return;
        print("shooting");
        GameObject projectile = Instantiate(projectilePrefab, firepoint.position, firepoint.rotation);
        projectile.GetComponent<Rigidbody2D>().AddForce(
        firepoint.up * projectile.GetComponent<standartProjectile>().speed,
        ForceMode2D.Impulse
        );

        cooldownStarter();


        float cooldownElapsedTime = targetTime - Time.time;
        float normalizedCDElapsedTime = cooldownElapsedTime / cooldown;
        cooldownImage.fillAmount = cooldownElapsedTime / 100f;


    }
}
