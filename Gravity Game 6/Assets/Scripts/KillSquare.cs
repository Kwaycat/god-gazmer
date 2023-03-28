using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillSquare : MonoBehaviour
{
    public GameObject player;
    public bool isDead = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        player.SetActive(false);
        isDead = true;
    }
}
