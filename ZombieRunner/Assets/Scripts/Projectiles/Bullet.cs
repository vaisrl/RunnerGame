using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    public float damage =1f;
    public Rigidbody2D rb;
    private float lifeTime = 0.29f;
    private float startLifeTime;
    public GameObject bloodEffect;
    public GameObject head, body, arm, leg;


    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void Update()
    {
        startLifeTime += Time.deltaTime;
        if (startLifeTime >= lifeTime)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }


}
