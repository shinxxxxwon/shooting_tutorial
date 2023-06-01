using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class SpawnManager : MonoBehaviour
{
  public GameObject[] EnemyPrefabs;


  void Start()
  {
    SpawnRandom();
  }

  void SpawnRandom()
  {
    GameObject prefab = EnemyPrefabs[Random.Range(0, EnemyPrefabs.Length)];
    Points points = new Points();
    Vector2 pos = points.position[Random.Range(0, points.position.Length)].GetPosition();
    
    SpawnEnemy(prefab, pos);
    Invoke("SpawnRandom", 1.5f);
  }

  public void SpawnEnemy(GameObject prefab, Vector3 position)
  {
    GameObject enemy = Instantiate(prefab);
    enemy.transform.position = position;

    enemy.GetComponent<Enemy>().Move();
  }
}
