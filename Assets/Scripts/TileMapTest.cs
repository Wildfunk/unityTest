using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapTest : MonoBehaviour
{
    // Start is called before the first frame update
    private Tilemap tmTest; 
    public GameObject tileMap;
    public TileBase tbTest;

    public const string nameDataFile = "TileMapStruct5";
    List<TileMapDataTest> dataTests2 = new List<TileMapDataTest>();
    void Start()
    {
        tmTest = gameObject.GetComponent<Tilemap>();
        dataTests2 = FileHandler.ReadFromJSON<TileMapDataTest>(nameDataFile);
        foreach (var item in dataTests2)
        {
            Debug.Log(item.tile + item.x + item.y);
            tmTest.SetTile((new Vector3Int(item.x, item.y, 0)), tbTest);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
