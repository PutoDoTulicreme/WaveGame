using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(enemy, transform.position, Quaternion.identity);
        }
    }
}