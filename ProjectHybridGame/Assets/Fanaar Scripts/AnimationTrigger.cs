using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public GameObject Dark1;
    public GameObject Dark2;
    public GameObject Dark3;
    public GameObject Dark4;

    public GameObject Player1;
    public GameObject Player2;

    private bool Animate = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Reunite")
        {
            Dark1.SetActive(false);
            Dark2.SetActive(false);
            Dark3.SetActive(false);
            Dark4.SetActive(false);
            Debug.Log("Animation!");
        }
    }
}
