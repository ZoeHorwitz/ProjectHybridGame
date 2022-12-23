using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementWasd : MonoBehaviour
{
    // Start is called before the first frame update

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
        rigidbody.velocity = new Vector2(movementX * moveSpeed * Time.deltaTime, movementY * moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W))
        {
            movementY = 1;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            movementY = -1;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            movementX = -1;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            movementX = 1;
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            movementY = 0;
        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            movementX = 0;
        }
    }
}
