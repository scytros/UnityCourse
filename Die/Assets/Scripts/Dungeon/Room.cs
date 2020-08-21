using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Room : MonoBehaviour
{
    [SerializeField] private List<GameObject> prefabEnemies = new List<GameObject>();
    [SerializeField] private List<GameObject> enemiesLeft = new List<GameObject>();

    [SerializeField] private Tilemap doorTiles;
    [SerializeField] private Tilemap wallTiles;
    [SerializeField] private Tilemap startTriggerTiles;
    private StartTrigger startRoomTrigger;

    [SerializeField] private int id;
    [SerializeField] private bool isCompleted;
    [SerializeField] private bool keyHasDropped;

    public bool IsCompleted { get { return isCompleted; } }
    public bool KeyHasDropped { get { return keyHasDropped; } set { keyHasDropped = value; } }
    public bool HasEnemiesLeft
    {
        get
        {
            if (enemiesLeft.Count <= 0)
            {
                return false;
            }

            return true;
        }
    }

    public StartTrigger StartRoomTrigger { get { return startRoomTrigger; } }

    public int Id { get { return id; } }
    public Vector2 GetRandomPositionInRoom { get { return CalculateRoomBounds(); } }

    private void Awake()
    {
        startRoomTrigger = startTriggerTiles.GetComponent<StartTrigger>();
    }

    public void Complete()
    {
        Debug.Log("Doors of room " + "'" + id + "'" + " have been opened.");

        isCompleted = true;
        doorTiles.gameObject.SetActive(false);
    }

    private Vector2 CalculateRoomBounds()
    {
        int Offset = 2;

        Vector2 min = wallTiles.CellToWorld(wallTiles.cellBounds.min);
        Vector2 max = wallTiles.CellToWorld(wallTiles.cellBounds.max);

        Vector2 spawnPos = new Vector2();
        spawnPos.x = Random.Range(min.x + Offset, max.x - Offset);
        spawnPos.y = Random.Range(min.y + Offset, max.y - Offset);

        return spawnPos;
    }

    public void SpawnEnemies()
    {
        for (int i = 0; i < prefabEnemies.Count; i++)
        {
            Vector2 spawnPos = GetRandomPositionInRoom;
            GameObject enemyobj = GameObject.Instantiate(prefabEnemies[i].gameObject, spawnPos, Quaternion.identity);
            enemiesLeft.Add(enemyobj);
        }
    }

    public void RemoveEnemy(GameObject enemy)
    {
        enemiesLeft.Remove(enemy);
    }
}