using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public partial class RoomManager : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private GameObject roomKey;

    [SerializeField] private List<Room> rooms = new List<Room>();
    [SerializeField] private Room currentRoom;

    private void Awake()
    {
        rooms = GetComponentsInChildren<Room>().ToList();
        currentRoom = rooms[1];
    }

    public void CompleteCurrentRoom()
    {
        gameManager.PlayAudio(GameManager.Sound.RoomCompleted);

        currentRoom.Complete();

        if (IsNotLastRoom(currentRoom))
        {
            currentRoom = rooms[currentRoom.Id + 1];
        }
        else
        {
            FindObjectOfType<EndUI>().SetEndScreen(true);
        }
    }

    public void StartRoom()
    {
        if (!currentRoom.IsCompleted)
        {
            gameManager.PlayAudio(GameManager.Sound.RoomStart);
            currentRoom.StartRoomTrigger.ListeningToCollision = false;

            currentRoom.SpawnEnemies();
        }
    }

    private void CreateKey()
    {
        Vector2 spawnPos = currentRoom.GetRandomPositionInRoom();
        GameObject.Instantiate(roomKey, spawnPos, Quaternion.identity);
    }

    public void ActivateNextRoomTrigger()
    {
        currentRoom.StartRoomTrigger.ListeningToCollision = true;
    }

    public void RemoveEnemy(GameObject enemy)
    {
        currentRoom.RemoveEnemy(enemy);
        if (!currentRoom.HasEnemiesLeft)
        {
            CreateKey();
        }
    }

    private bool IsNotLastRoom(Room room)
    {
        if ((currentRoom.Id + 1) < rooms.Count)
        {
            return true;
        }

        return false;
    }
}