using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnPoints;
    // Use this for initialization
    void Start()
    {
        //Spawn our enemies repeatedly
        InvokeRepeating("SpawnEnemy", 2f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnEnemy()
    {
        //find a random point between zero and the amount of possible spawn points
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        //Create our enemy at the randomly selected point
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

    }
}
