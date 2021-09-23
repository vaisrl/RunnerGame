using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{    
    [SerializeField] private float jumpPower;
    private Rigidbody2D rb;
    private Animator anim;
    private BoxCollider2D coll2D;
    [SerializeField] private LayerMask jumpable;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        coll2D = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            anim.SetTrigger("Jump");            
        }
    }

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, 3f);
    }

    private bool isGrounded()
    {         
        return Physics2D.BoxCast(coll2D.bounds.center, coll2D.bounds.size, 0f, Vector2.down, 0.1f, jumpable);
    }   

}
