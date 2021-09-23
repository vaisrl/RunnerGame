using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
    private float speed;
    private float lifeTime = 15f;
    private float startLifeTime;
    private Rigidbody2D rb;


    private void Start()
    {
        speed = Random.Range(5, 7);
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {        
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        startLifeTime += Time.deltaTime;
        if (startLifeTime >= lifeTime)
        {
            Destroy(gameObject);
        }
    }

}
