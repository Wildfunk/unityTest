using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapTest : MonoBehaviour
{
    // Start is called before the first frame update
    private Tilemap tmTest; 
    public GameObject tileMap;
    public TileBase tbTest;
    public TileBase tbWall;
    public TileBase tbWoodFloor;

    private Tilemap tmFenceTest;
    public GameObject tileMapFence;
    public TileBase tbFenceTest;
    public TileBase tbFenceBTest;
    public TileBase tbBedTest;
    public TileBase tbDeskTest;
    
    



    public const string nameDataFile = "TileMapStruct7";
    List<TileMapDataTest> dataTests2 = new List<TileMapDataTest>();
    void Start()
    {
        tmTest = tileMap.GetComponent<Tilemap>();
        tmFenceTest = tileMapFence.GetComponent<Tilemap>();
        dataTests2 = FileHandler.ReadFromJSON<TileMapDataTest>(nameDataFile);
        TileBase[] tilesLayer1 = { tbTest, tbWoodFloor, tbWall };
        TileBase[] tilesLayer2 = {tbTest, tbFenceTest, tbFenceBTest, tbBedTest, tbDeskTest};
        foreach (var item in dataTests2)
        {
            if(item.layer == "Tilemap")
            {
                foreach (var tile in tilesLayer1)
                {
                    if (tile.name == item.tile)
                    {
                        print("aaaaaaaaaaaaaaaaaaaaaaaaaaaa");
                        tmTest.SetTile((new Vector3Int(item.x, item.y, 0)), tile);

                        

                        
                    }

                }
            }
            if (item.layer == "TilemapFence")
            {
                foreach (var tile in tilesLayer2)
                {
                    if (tile.name == item.tile)
                    {
                        tmFenceTest.SetTile((new Vector3Int(item.x, item.y, 0)), tile);

                    }
                }
                
            }
        }
        //GameObject prefab1 = tmFenceTest.GetInstantiatedObject(new Vector3Int(-5, 12, 0));
        //print(prefab1);
        //prefab1.transform.Rotate(new Vector3(0, 90f, 0));
        GameObject prefab = tmTest.GetInstantiatedObject(new Vector3Int(-11, 9, 0));
        prefab.transform.Rotate(new Vector3(0f, -90f, 0));
        GameObject prefab2 = tmTest.GetInstantiatedObject(new Vector3Int(-11, 8, 0));
        prefab2.transform.Rotate(new Vector3(0f, -90f, 0));
        GameObject prefab3 = tmFenceTest.GetInstantiatedObject(new Vector3Int(-3, 12, 0));
        prefab3.transform.Rotate(new Vector3(0f, -90f, 0));
    }
}

    // Update is called once per frame


