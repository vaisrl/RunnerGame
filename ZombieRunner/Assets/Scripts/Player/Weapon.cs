using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject ShootingEffect;
    private float timeBetweenShots;
    [SerializeField] private float startTimeBetweenShots = 0.7f;
    private float currentAmmo;
    private float maxAmmo = 5;
    public Image[] bullets;
    public Sprite bullet;
    public Sprite emptyBullet;
    private float numOfAmmo =5f;


    private void Start()
    {
        currentAmmo = maxAmmo;
    }
        
    void Update()
    {
        if (timeBetweenShots <= 0)
        {
            if (Input.GetMouseButtonDown(0) && currentAmmo > 0)
            {
                SoundManager.PlaySound("shot");
                Instantiate(ShootingEffect, firePoint.position, Quaternion.identity);
                StartCoroutine(Shoot());
                timeBetweenShots = startTimeBetweenShots;
                currentAmmo--;
            }
        }
        else
        {
            timeBetweenShots -= Time.deltaTime;
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            SoundManager.PlaySound("reload");
            Reload();
        }


        if (currentAmmo > numOfAmmo)
        {
            currentAmmo = numOfAmmo;
        }
        for (int i = 0; i < bullets.Length; i++)
        {
            if (i < Mathf.RoundToInt(currentAmmo))
            {
                bullets[i].sprite = bullet;
            }
            else
            {
                bullets[i].sprite = emptyBullet;
            }
            if (i < numOfAmmo)
            {
                bullets[i].enabled = true;
            }
            else
            {
                bullets[i].enabled = false;
            }
        }

    }

    IEnumerator Shoot()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right);
        
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);        

        yield return 0; 
    } 

    public void Reload()
    {
        currentAmmo = maxAmmo;
    }

}
