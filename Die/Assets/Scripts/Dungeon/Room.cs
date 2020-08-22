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

    private List<Vector2> tileWorldLocations = new List<Vector2>();

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

    private void Awake()
    {
        startRoomTrigger = startTriggerTiles.GetComponent<StartTrigger>();
    }

    public void Complete()
    {
        isCompleted = true;
        doorTiles.gameObject.SetActive(false);
    }

    public void SpawnEnemies()
    {
        for (int i = 0; i < prefabEnemies.Count; i++)
        {
            GameObject enemyobj = GameObject.Instantiate(prefabEnemies[i].gameObject, GetRandomPositionInRoom(), Quaternion.identity);
            enemiesLeft.Add(enemyobj);
        }
    }

    public Vector2 GetRandomPositionInRoom()
    {
        foreach (var pos in wallTiles.cellBounds.allPositionsWithin)
        {
            Vector3Int localPlace = new Vector3Int(pos.x, pos.y, pos.z);
            Vector3 place = wallTiles.CellToWorld(localPlace);
            if (!wallTiles.HasTile(localPlace))
            {
                tileWorldLocations.Add(place);
            }
        }

        System.Random random = new System.Random();
        return tileWorldLocations[random.Next(0, tileWorldLocations.Count)];
    }

    public void RemoveEnemy(GameObject enemy)
    {
        enemiesLeft.Remove(enemy);
    }
}