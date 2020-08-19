using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    [SerializeField] private List<Room> rooms = new List<Room>();
    [SerializeField] private Room currentRoom;

    public void UpdateCurrentRoom(int id)
    {
        currentRoom = rooms[id];

        Debug.Log("Current room is now: " + id + "!");
    }

    public void CompleteRoom()
    {
        //Disable room doors
    }

    [Serializable]
    public class Room
    {
        public int Id { get; set; }
        public bool Completed { get; set; }
        public Vector2 RoomSize { get; set; }

        public GameObject RoomGameObject;

        public Room(int id, Vector2 roomSize)
        {
            Id = id;
            RoomSize = roomSize;
        }
    }
}
