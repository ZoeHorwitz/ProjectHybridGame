using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    float movementX;
    float movementY;
    private void Start()
    {
        movementX = 0;
        movementY = 0;
    }
    public void Update()
    {
        string value = ArduinoConnect.Instance.value;
        rb.velocity = new Vector2(movementX * moveSpeed * Time.deltaTime, movementY * moveSpeed * Time.deltaTime);

        switch (value)
        {
            case "4":
                movementY = 1;
                break;
            case "3":
                movementY = -1;
                break;
            case "1":
                movementX = -1;
                break;
            case "2":
                movementX = 1;
                break;
            case "0":
                movementX = 0;
                movementY = 0;
                break;
        }

    }

}