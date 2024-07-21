using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int gridSize = 4;
    public GameObject tilePrefab;
    private Tile[,] grid;
    
    void Start()
    {
        InitializeGrid();
        SpawnTile();
        SpawnTile();
    }

    void InitializeGrid()
    {
        grid = new Tile[gridSize, gridSize];
        for (int y = 0; y < gridSize; y++)
        {
            for (int x = 0; x < gridSize; x++)
            {
                GameObject tile = Instantiate(tilePrefab, transform);
                tile.GetComponent<RectTransform>().anchoredPosition = new Vector2(x * 100, y * 100);
                grid[x, y] = tile.GetComponent<Tile>();
            }
        }
    }

    void SpawnTile()
    {
        // Find all empty spots
        List<Vector2Int> emptySpots = new List<Vector2Int>();
        for (int y = 0; y < gridSize; y++)
        {
            for (int x = 0; x < gridSize; x++)
            {
                if (grid[x, y].value == 0)
                {
                    emptySpots.Add(new Vector2Int(x, y));
                }
            }
        }

        if (emptySpots.Count > 0)
        {
            Vector2Int spawnPosition = emptySpots[Random.Range(0, emptySpots.Count)];
            grid[spawnPosition.x, spawnPosition.y].SetValue(Random.Range(0, 10) == 0 ? 4 : 2);
        }
    }

    void Update()
    {

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Move(Vector2.left);
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Move(Vector2.right);
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Move(Vector2.up);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Move(Vector2.down);
            }
    }
    
    void Move(Vector2 direction)
    {
        bool moved = false;

        for (int y = 0; y < gridSize; y++)
        {
            for (int x = 0; x < gridSize; x++)
            {
                // Determine the target position and move tiles accordingly
                // Implement your move and merge logic here
            }
        }

        if (moved)
        {
            SpawnTile();
        }
    }


}
