using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deployer : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float respawnTime = 1.0f;
    public GameObject EnemyPrefab2;
    public float respawnTime2 = 1.0f;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(Wave());
        StartCoroutine(Wave2());
    }

    private void spawnEnemy()
    {
        GameObject a = Instantiate(EnemyPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x + 2, Random.Range(0, screenBounds.y));
    }

    private void spawnEnemy2()
    {
        GameObject b = Instantiate(EnemyPrefab2) as GameObject;
        b.transform.position = new Vector2(screenBounds.x + 2, Random.Range(0, screenBounds.y));
    }

    IEnumerator Wave()
    {
        while (true)
        {           
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
    IEnumerator Wave2()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime2);
            spawnEnemy2();
        }
    }
}
