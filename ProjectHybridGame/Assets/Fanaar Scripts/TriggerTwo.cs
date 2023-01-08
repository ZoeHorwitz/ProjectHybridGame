using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTwo : MonoBehaviour
{
    public GameObject Door2;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Door2.SetActive(false);
            Debug.Log("Test!");
        }
    }
}
