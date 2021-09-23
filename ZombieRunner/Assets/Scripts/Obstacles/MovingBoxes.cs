using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBoxes : MonoBehaviour
{
    private float speed = 5f;
    private float lifeTime = 15f;
    private float startLifeTime;

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
