using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public Rigidbody2D player;

      void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>();
    }

    void Update()
    {   
        if(Input.GetKeyDown(KeyCode.Space))
        {
            int horizontally = Random.Range(-10, 11);
            int vertically = Random.Range(-10,11);
            Vector2 spawnPosition = player.transform.position + new Vector3(horizontally, vertically); // Offset by 10 units horizontally
            Instantiate(enemy, spawnPosition, Quaternion.identity);
        }
    }
}