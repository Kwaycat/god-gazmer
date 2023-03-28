using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public bool isDead;

    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.gameObject.tag == "Obstacle")
        {
            gameObject.SetActive(false);
            isDead = true;
        }
    }
    
}
