using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Room : MonoBehaviour
{
    [SerializeField] private Tilemap DoorTiles;
    [SerializeField] private Tilemap WallTiles;

    [SerializeField] private int id;
    [SerializeField] private bool isCompleted;

    public int Id { get { return id; } }
    public Vector2 RoomBounds { get { return CalculateRoomBounds(); } }

    public void Complete()
    {
        Debug.Log("Doors of room " + "'" + id + "'" + " have been opened.");

        isCompleted = true;
        DoorTiles.gameObject.SetActive(false);
    }

    private Vector2 CalculateRoomBounds()
    {
        int Offset = 2;

        Vector2 min = WallTiles.CellToWorld(WallTiles.cellBounds.min);
        Vector2 max = WallTiles.CellToWorld(WallTiles.cellBounds.max);

        Vector2 spawnPos = new Vector2();
        spawnPos.x = Random.Range(min.x + Offset, max.x - Offset);
        spawnPos.y = Random.Range(min.y + Offset, max.y - Offset);

        return spawnPos;
    }
}