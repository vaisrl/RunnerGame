using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject [] enemies;
    Vector2 whereToSpawn;
    public float spawnRate = 10f;
    float nextSpawn = 0;
    

    
    void Update()
    {
        
        if (Time.time > nextSpawn)
        {
            int random = Random.Range(0, 4);            
            nextSpawn = Time.time + spawnRate;
            whereToSpawn = new Vector2(transform.position.x, transform.position.y);
            Instantiate(enemies[random], whereToSpawn, Quaternion.identity);
        }

    }
}
