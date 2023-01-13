using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public GameObject Dark1;
    public GameObject Dark2;
    public GameObject Dark3;
    public GameObject Dark4;

    public Animator Anim;
    private void Start()
    {
        Anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Dark1.SetActive(false);
            Dark2.SetActive(false);
            Dark3.SetActive(false);
            Dark4.SetActive(false);

            Debug.Log("Test!");

            Anim.Play("Darkness_Fade_Out");
        }

        //if(Anim.Play("Darkness_Fade_Out"))
    }
}
