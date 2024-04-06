using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnrate = 5f;

    public GameObject[] enemyPrefab;

    public bool spawnCondition = true;

    private void Start()
    {
        StartCoroutine(enemySpawner());
    }

    private IEnumerator enemySpawner ()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnrate);

        while(true)
        {
            yield return wait;

            int rand = Random.Range(0, enemyPrefab.Length);
            GameObject enemyToSpawn = enemyPrefab[rand];

            Instantiate(enemyToSpawn, transform.position, Quaternion.identity);
        }
    }
}
