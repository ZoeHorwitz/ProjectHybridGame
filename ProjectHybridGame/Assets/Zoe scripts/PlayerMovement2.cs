using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
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
            case "5":
                movementY = 1;
                break;
            case "6":
                movementY = -1;
                break;
            case "7":
                movementX = -1;
                break;
            case "8":
                movementX = 1;
                break;
            case "9":
                movementX = 0;
                movementY = 0;
                break;
        }

    }

}    