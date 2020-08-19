using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCompleter : MonoBehaviour
{
    [SerializeField] private int roomKeyId;

    private void Awake()
    {
        FindObjectOfType<RoomManager>().UpdateCurrentRoom(roomKeyId);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("opening doors of room: " + roomKeyId + "!");

        FindObjectOfType<RoomManager>().UpdateCurrentRoom(roomKeyId);
        Destroy(gameObject);
    }
}