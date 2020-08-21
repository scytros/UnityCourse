using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTrigger : MonoBehaviour
{
    public bool ListeningToCollision { get; set; } = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() && ListeningToCollision)
        {
            Debug.Log("hihi");
            gameObject.SetActive(false);
            GetComponentInParent<RoomManager>().StartRoom();
        }
    }
}