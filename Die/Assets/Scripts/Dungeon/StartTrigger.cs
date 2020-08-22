using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class StartTrigger : MonoBehaviour
{
    public bool ListeningToCollision { get; set; } = true;
    private TilemapCollider2D collider;

    private void Awake()
    {
        collider = GetComponent<TilemapCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() && ListeningToCollision)
        {
            ListeningToCollision = false;
            GetComponentInParent<RoomManager>().StartRoom();
        }
    }
}