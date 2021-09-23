using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {        

        if (collision.tag == "Player")
        {
            SoundManager.PlaySound("goingIntoWallofHands");
            collision.GetComponent<Animator>().SetTrigger("Death");
            Time.timeScale = 0f;
            FindObjectOfType<RestartMenu>().restartMenuUI.SetActive(true);
        }

    }

}
