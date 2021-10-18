using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Tilemaps;
using UnityEngine.Tilemaps;
using System.Linq;

public class TileMap : MonoBehaviour
{
    // Start is called before the first frame update
    private Tilemap tm;
    //private Grid gr;
    //private TileBase tb;
    //private Tile tl;
    public GameObject tileMap;
    //public GameObject grid;
    public TileBase tileBase;
    public TileMapStruct[] arr;
    public TileMapDataTest[] arrT;
    public DictionaryBase map;
    
    //public TileMapData tmData;
    public TileMapStruct tmData;
    public TileMapDataTest tmDataT;
    public const string pathData = "Data/test";
    public const string nameDataFile = "TileMapStruct5";


    List<TileMapDataTest> dataTests = new List<TileMapDataTest>();


    void Start()
    {
        //print(gameObject + "a"); 
        tm = gameObject.GetComponent<Tilemap>();
        //print(tm.GetTile(new Vector3Int(7,-1,0)));
        tm.SetTile((new Vector3Int(8, -1, 0)),tileBase);


        BoundsInt bounds = tm.cellBounds;
        //print(bounds + "bounds");
        TileBase[] allTiles = tm.GetTilesBlock(bounds);
        //print(allTiles + "allTiles first");



        for (int x = bounds.min.x; x < bounds.max.x; x++)
        {
            for (int y = bounds.min.y; y < bounds.max.y; y++)
            {
                var cellPosition = new Vector3Int(x, y, 0);
                //var sprite = tm.GetSprite(cellPosition);
                var tile = tm.GetTile(cellPosition);
                var position = cellPosition;
               
                if (!tile)//&& !sprite)
                {
                    continue;
                }
                //var dataFound = SaveLoadSystemData.LoadData<TileMapData>(pathData, nameDataFile);

                //if (dataFound == null)
                //{
                   
                    
                        try
                        {
                            
                            dataTests.Add(new TileMapDataTest(tile.name, position.x, position.y));
                            FileHandler.SaveToJSON<TileMapDataTest>(dataTests, nameDataFile);
                            
                        }
                        catch (System.ArgumentNullException e)
                        {

                            throw e;
                        }
                        
                       

                    
                    
                //}
                
                //Save();
            }
            print("tile");
        }
        //Save();

    }
    
    // Update is called once per frame
    void Update()
    {

    }

}
    

