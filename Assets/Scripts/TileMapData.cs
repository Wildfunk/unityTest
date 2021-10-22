using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Tilemaps;

public sealed class TileMapData 
{
    public TileBase tile;
    public Vector3Int position;

    public TileMapData(
        TileBase tile,
        Vector3Int position)

    {
        Tile = tile;
        Position = position;

    }

    public TileBase Tile { get; }
    public Vector3Int Position { get; }
}

public struct TileMapStruct
{
    public TileBase tile;
    public Vector3Int position;

    public TileMapStruct(
        TileBase Tile,
        Vector3Int Position)

    {
        tile = Tile;
        position = Position;

    }

    
}

[Serializable]
public class TileMapDataTest
{
    public string layer;
    public string tile;
    public int x;
    public int y;
    public float xRotate;
    public float yRotate;

    public TileMapDataTest(string Tilee, int X, int Y, string layerr)
    {
        tile = Tilee;
        x = X; 
        y = Y;
        layer = layerr;
    }
}