using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOne : MonoBehaviour
{
    public GameObject Door1;
    public GameObject Flower1;
    public AudioSource Doors;

     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Door1.SetActive(false);
            Flower1.SetActive(false);
            Doors.Play();
            Debug.Log("Test!");
        }
    }
}
