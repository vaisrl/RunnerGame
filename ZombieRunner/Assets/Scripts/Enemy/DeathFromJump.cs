using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathFromJump : MonoBehaviour
{

    public GameObject bloodEffect;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            FindObjectOfType<ScoreManager>().score += 10f;
            SoundManager.PlaySound("zombieDeath");
            collision.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 20f, ForceMode2D.Impulse);
            Destroy(transform.parent.gameObject);
            Instantiate(bloodEffect, transform.parent.position, Quaternion.identity);
        }
    }


}
