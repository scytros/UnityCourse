using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public partial class RoomManager : MonoBehaviour
{
    [SerializeField] private GameObject roomKey;

    [SerializeField] private List<Room> rooms = new List<Room>();
    [SerializeField] private Room currentRoom;

    [SerializeField] private List<Enemy> enemies = new List<Enemy>();

    private void Awake()
    {
        rooms = GetComponentsInChildren<Room>().ToList();
        currentRoom = rooms[0];
    }

    private void Start()
    {
        CreateKey();
    }

    public void CompleteCurrentRoom()
    {
        currentRoom.Complete();

        if ((currentRoom.Id + 1) < rooms.Count)
        {
            currentRoom = rooms[currentRoom.Id + 1];
        } 
    }

    public void CreateKey()
    {
        Vector2 spawnPos = currentRoom.RoomBounds;
        GameObject.Instantiate(roomKey, spawnPos, Quaternion.identity);
    }
}
