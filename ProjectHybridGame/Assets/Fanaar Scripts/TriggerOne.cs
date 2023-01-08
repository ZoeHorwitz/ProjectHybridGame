using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOne : MonoBehaviour
{
    public GameObject Door1;

     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Door1.SetActive(false);
            Debug.Log("Test!");
        }
    }
}
