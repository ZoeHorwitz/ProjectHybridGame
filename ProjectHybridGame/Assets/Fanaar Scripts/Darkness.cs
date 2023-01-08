using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Darkness : MonoBehaviour
{
    public GameObject LeftDark;
    public GameObject RightDark;
    public GameObject TopDark;
    public GameObject BottomDark;

    public float Speed;
    private float AnimationSpeed;

    private bool DarknessCollision = false;

    private void Start()
    {
        AnimationSpeed = Speed * Time.deltaTime;
        
    }
    private void FixedUpdate()
    {
        if(DarknessCollision = true)
        {
            DarknessAnimation();
        }
        else
        {

        }
    }
    public void DarknessAnimation()
    {
        LeftDark.transform.DOMoveX(0f, AnimationSpeed);
        RightDark.transform.DOMoveX(0f, AnimationSpeed);

        TopDark.transform.DOMoveY(0f, AnimationSpeed);
        BottomDark.transform.DOMoveY(0f, AnimationSpeed);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            LeftDark.transform.DOMoveX(13f, 0f);
            RightDark.transform.DOMoveX(-13f, 0f);
            Debug.Log("Hey!");
        }
    }
}
