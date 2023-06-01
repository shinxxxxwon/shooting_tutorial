using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum ItemPrefabs{
    Coin, SpeedUp, PowerUp, DefenseUp
}

public struct Point{
    float x;
    float y;

    public Point(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public Vector2 GetPosition()
    {
        return new Vector2(this.x, this.y);
    }
}

public class ItemManager : MonoBehaviour
{
     public GameObject[] ItemPrefabs;

    

    void Start()
    {
       SpawnRandom();
    }


    void SpawnRandom()
    {
        GameObject prefab = ItemPrefabs[Random.Range(0, ItemPrefabs.Length)];
        Points points = new Points();
        Vector2 pos = points.position[Random.Range(0, points.position.Length)].GetPosition();
        
        SpawnItem(prefab, pos);
        Invoke("SpawnRandom", 2.0f);
    }

    void SpawnItem(GameObject itemPrefabs, Vector2 position)
    {
        GameObject item = Instantiate(itemPrefabs);
        item.transform.position = position;
    }

}

public class Points
{
    public Point[] position = {
        new Point(2 ,-1),
        new Point(1 ,-2),
        new Point(0 ,-1),
        new Point(2 ,0),
        new Point(0 ,2),
        new Point(-1 ,0),
        new Point(1 ,0),
        new Point(0 ,-1),
        new Point(-2 ,0),
        new Point(0 , -2)
     };
}
