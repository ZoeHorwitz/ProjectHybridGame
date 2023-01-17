using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTwo : MonoBehaviour
{
    public GameObject Door2;
    public GameObject Flower2;
    public AudioSource Doors;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Door2.SetActive(false);
            Flower2.SetActive(false);
            Debug.Log("Test!");
            Doors.Play();
        }
    }
}
