using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D enemy;
    public float moveSpeed = 5f;
    public float changeDirectionInterval = 2f; // Change direction every 2 seconds

    private Vector2 randomDirection;
    private float directionChangeTimer;

    void Start()
    {
        // Initialize the Rigidbody2D reference and set the first random direction
        enemy = GetComponent<Rigidbody2D>();
        SetRandomDirection();
        directionChangeTimer = changeDirectionInterval;
    }

    void Update()
    {
        // Update the timer
        directionChangeTimer -= Time.deltaTime;

        if(directionChangeTimer <= 0f)
        {
            SetRandomDirection(); // Change direction when the timer runs out
            directionChangeTimer = changeDirectionInterval; // Reset the timer
        }

        // Move the enemy in the current random direction
        enemy.velocity = randomDirection * moveSpeed;
    }

    private void SetRandomDirection()
    {
        // Generate a random direction within a 2D circle and normalize it
        randomDirection = Random.insideUnitCircle.normalized;
    }
}
