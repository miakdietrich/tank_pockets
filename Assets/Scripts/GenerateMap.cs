using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TileMaps;

//Generate Array
public static int[,] GenerateArray(int width, int height, bool empty)
{
  int[,] map = new int[width, height];
  for (int x = 0; x < map.GetUpperBound(0); x++)
  {
    for (int y = 0; y < map.GetUpperBound(1); y++)
    {
      if (empty)
      {
        map[x, y] = 0;
      }
      else
      {
        map[x, y] = 1;
      }
    }
  }
  return map;
}

//Render Map
public static void RenderMap(int[,] map, Tilemap tilemap, TileBase tile)
{
  //Clear the map (ensures we dont overlap)
  tilemap.ClearAllTiles();
  //Loop through the width of the map
  for (int x = 0; x < map.GetUpperBound(0); x++)
  {
    //Loop through the height of the map
    for (int y = 0; y < map.GetUpperBound(1); y++)
    {
      // 1 = tile, 0 = no tile
      if (map[x, y] == 1)
      {
        tilemap.SetTile(new Vector3Int(x, y, 0), tile);
      }
    }
  }
}

//Update Map
public static void RenderMap(int[,] map, Tilemap tilemap, TileBase tile)
{
  //Clear the map (ensures we dont overlap)
  tilemap.ClearAllTiles();
  //Loop through the width of the map
  for (int x = 0; x < map.GetUpperBound(0); x++)
  {
    //Loop through the height of the map
    for (int y = 0; y < map.GetUpperBound(1); y++)
    {
      // 1 = tile, 0 = no tile
      if (map[x, y] == 1)
      {
        tilemap.SetTile(new Vector3Int(x, y, 0), tile);
      }
    }
  }
}