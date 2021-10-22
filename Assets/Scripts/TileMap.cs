using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMap : MonoBehaviour
{
    // Start is called before the first frame update
    private Tilemap tm;
    public GameObject tileMap;
    private Tilemap tmFence;
    public GameObject tileMapFence;
  
    public const string pathData = "Data/test";
    public const string nameDataFile = "TileMapStruct7";


    List<TileMapDataTest> dataTests = new List<TileMapDataTest>();


    void Start()
    {
        tm = tileMap.GetComponent<Tilemap>();
        tmFence = tileMapFence.GetComponent<Tilemap>();
        GameObject prefab1 = tm.GetInstantiatedObject(new Vector3Int(-11, 9, 0));
        Debug.Log(prefab1.transform.rotation + "1" + prefab1 );
        prefab1.transform.Rotate(new Vector3(x: 0, y: 90, 0));
        Debug.Log(prefab1.transform.rotation + "2");
        Debug.Log(" obvjeto aaaaaaaaa");

        BoundsInt bounds = tm.cellBounds;
        TileBase[] allTiles = tm.GetTilesBlock(bounds);

        BoundsInt boundsFence = tm.cellBounds;
        TileBase[] allTilesFence = tm.GetTilesBlock(bounds);


        for (int x = bounds.min.x; x < bounds.max.x; x++)
        {
            for (int y = bounds.min.y; y < bounds.max.y; y++)
            {
                var cellPosition = new Vector3Int(x, y, 0);
                var tile = tm.GetTile(cellPosition);
                var position = cellPosition;
                var layer = tm.name;
                
                if (!tile)//&& !sprite)
                {
                    continue;
                }
                    
                try
                {
                    dataTests.Add(new TileMapDataTest(tile.name, position.x, position.y,layer));
                    FileHandler.SaveToJSON<TileMapDataTest>(dataTests, nameDataFile);
                            
                }
                catch (System.ArgumentNullException e)
                {

                    throw e;
                }
            }
            
        }
        print("primer tm suelo");
        for (int x = boundsFence.min.x; x < boundsFence.max.x; x++)
        {
            for (int y = boundsFence.min.y; y < boundsFence.max.y; y++)
            {
                var cellPosition = new Vector3Int(x, y, 0);
                var tile = tmFence.GetTile(cellPosition);
                var position = cellPosition;
                var layer = tmFence.name;
                if (!tile)//&& !sprite)
                {
                    continue;
                }

                try
                {
                    dataTests.Add(new TileMapDataTest(tile.name, position.x, position.y, layer));
                    FileHandler.SaveToJSON<TileMapDataTest>(dataTests, nameDataFile);

                }
                catch (System.ArgumentNullException e)
                {

                    throw e;
                }
            }
        }
        print("segundo tm madera");

    }

    // Update is called once per frame
    void Update()
    {
        
    }





    //public TileMapStruct[] arr;
    //public TileMapDataTest[] arrT;
    //public DictionaryBase map;

    //public TileMapData tmData;
    //public TileMapStruct tmData;
    //public TileMapDataTest tmDataT;
}


