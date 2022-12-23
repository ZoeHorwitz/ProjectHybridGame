using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementArrows : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rigidbody;

    float movementX;
    float movementY;

    private void Start()
    {
        movementX = 0;
        movementY = 0;
    }
    private void Update()
    {
        /*movementX = Input.GetAxisRaw("Horizontal");
        movementY = Input.GetAxisRaw("Vertical");*/

        rigidbody.velocity = new Vector2(movementX * moveSpeed * Time.deltaTime, movementY * moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            movementY = 1;
        }

        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            movementY = -1;
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            movementX = -1;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            movementX = 1;
        }

        if(Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            movementY = 0;
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            movementX = 0;
        }
    }



}
