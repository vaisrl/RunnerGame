using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBG : MonoBehaviour
{
    [SerializeField] public float speed;
    private BoxCollider2D coll2D;
    public float width;



    private void Start()
    {
        coll2D = GetComponent<BoxCollider2D>();
        width = coll2D.size.x;        
    }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x <= -width)
        {
            Vector2 resetPosition = new Vector2(width * 2f, 0);
            transform.position = (Vector2)transform.position + resetPosition;
        }
    }

}
