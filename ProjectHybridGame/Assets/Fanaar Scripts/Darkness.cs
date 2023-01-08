using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Darkness : MonoBehaviour
{
    public GameObject LeftDark;
    public GameObject RightDark;
    public GameObject TopDark;
    public GameObject BottomDark;

    private float Speed = 10000;
    private float AnimationSpeed;

    private bool DarknessCollision = false;

    private void Start()
    {
        AnimationSpeed = Speed * 0.03f;
        DarknessAnimation();
    }

    private void FixedUpdate()
    {
        if (DarknessCollision == true)
        {
            SceneManager.LoadScene("Fanaar");
        }
    }

    public void DarknessAnimation()
    {
        LeftDark.transform.DOMoveX(0f, AnimationSpeed);
        RightDark.transform.DOMoveX(0f, AnimationSpeed);

        TopDark.transform.DOMoveY(0f, AnimationSpeed);
        BottomDark.transform.DOMoveY(0f, AnimationSpeed);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Hey!");
            DarknessCollision = true;
        }
    }
}
