using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillSquare : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawn_point;

    private void OnTriggerEnter2D(Collider2D other)
    {
        player.transform.position = respawn_point.transform.position;
    }
}
