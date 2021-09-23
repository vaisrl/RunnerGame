using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour
{
    public GameObject bloodEffect;
    public GameObject head, body, arm, leg;
    public ZombieHealthBar healthBar;
    public float health;
    public float maxHealth;
    Bullet bullet;

    private void Start()
    {
        health = maxHealth;
        healthBar.SetHealth(health, maxHealth);
    }   
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")  // death from bullet
        {
            
            if (health > 1)
            {
                TakeDamage(1f);
                healthBar.SetHealth(health, maxHealth);
            }
            else if (health <= 1)
            {
                SoundManager.PlaySound("zombieDeath");
                FindObjectOfType<ScoreManager>().score += 10f;
                Destroy(collision.gameObject);
                Instantiate(bloodEffect, transform.position, Quaternion.identity);
                Instantiate(head, transform.position, Quaternion.identity);
                Instantiate(arm, transform.position, Quaternion.identity);
                Instantiate(leg, transform.position, Quaternion.identity);
                Instantiate(body, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.tag == "Player") // death from player collision
        {
            SoundManager.PlaySound("zombieDeath");
            SoundManager.PlaySound("playerHurt");
            collision.gameObject.GetComponent<Animator>().SetTrigger("TakeDamage");
            FindObjectOfType<ScoreManager>().score += 10f;
            Instantiate(bloodEffect, transform.position, Quaternion.identity);
            Instantiate(head, transform.position, Quaternion.identity);
            Instantiate(arm, transform.position, Quaternion.identity);
            Instantiate(leg, transform.position, Quaternion.identity);
            Instantiate(body, transform.position, Quaternion.identity);
            Destroy(gameObject);
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(1);
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 7f, ForceMode2D.Impulse);
        }
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
    }

}
