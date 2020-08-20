using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCompleter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<Player>())
        {
            FindObjectOfType<RoomManager>().CompleteCurrentRoom();
            Destroy(gameObject);
        }
    }
}