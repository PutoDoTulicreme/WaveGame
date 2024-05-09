using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Rigidbody2D rb;
    public float movSpeed;
    float speedX, speedY;

    private Vector2 moveDirection;
   

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame , good for input processes
    private void Update()
    {
       ProcessInputs();

    }

    //FixedUpdates is called every fixed framerate fame, good for physics

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs(){

        // Raw gives only 0 or 1
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // normalized gives a vector of magnitude 1 ,
        moveDirection = new Vector2(moveX,moveY).normalized;
    }

    void Move(){
        rb.velocity = new Vector2(moveDirection.x * movSpeed, moveDirection.y * movSpeed);

    }
}
