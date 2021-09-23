using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceToBodyParts : MonoBehaviour
{
    public Rigidbody2D rb;
    public float directionX;
    public float directionY;
    public float torque;
    
    
    void Start()
    {
        directionX = Random.Range(-5, 5);
        directionY = Random.Range(5, 8);
        torque = Random.Range(5, 15);
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(new Vector2(directionX, directionY), ForceMode2D.Impulse);
        rb.AddTorque(torque, ForceMode2D.Force);
    }

}
