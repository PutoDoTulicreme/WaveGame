using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D enemy;
    private Rigidbody2D player; 
    public float moveSpeed = 5f;
    public float changeDirectionInterval = 2f; // Change direction every 2 seconds

    private Vector2 direction;
    private float directionChangeTimer;

    public float difficulty; //Aqui quanto maior for entre 0 e 1, mais provável é o enemy de se aproximar

    void Start()
    {
        enemy = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>();

        SetDirection();
        directionChangeTimer = changeDirectionInterval;
    }

    void Update()
    {
        // Update the timer
        directionChangeTimer -= Time.deltaTime;

        if(directionChangeTimer <= 0f)
        {
            SetDirection(); // Change direction when the timer runs out
            directionChangeTimer = changeDirectionInterval; // Reset the timer
        }

        // Move the enemy in the current random direction
        enemy.velocity = direction * moveSpeed;
    }

    private void SetDirection()
    {
        // Generate a random direction within a 2D circle and normalize it
        float random = Random.Range(0f, 1f);
        Vector2 currentPosition = transform.position;
        Vector2 playerPosition = player.transform.position;

        if(random > difficulty) 
        {
            direction = Random.insideUnitCircle.normalized;
        }
        else 
        {
            direction = (playerPosition - currentPosition).normalized;
        }
    }
}
