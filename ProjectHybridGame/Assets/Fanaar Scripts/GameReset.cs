using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameReset : MonoBehaviour
{
    public GameObject DarkLeft;
    public GameObject DarkRight;
    public GameObject DarkTop;
    public GameObject DarkBottom;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            DarkLeft.transform.DOMoveX(13f, 0f);
            DarkRight.transform.DOMoveX(-13f, 0f);
            Debug.Log("Hey!");
        }
    }
}
