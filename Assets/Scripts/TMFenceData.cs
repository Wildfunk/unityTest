using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Tilemaps;


[Serializable]
public class TMFenceDataTest
{
    public string layer;
    public string tile;
    public int y;
    public int x;

    public TMFenceDataTest(string Tilee, int X, int Y, string layerr)
    {
        tile = Tilee;
        x = X;
        y = Y;
        layer = layerr;
    }
}
