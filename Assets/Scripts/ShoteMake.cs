using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoteMake : MonoBehaviour
{
    public Animator anim;
    public AudioSource Myfx;
    public AudioClip ShotSFX;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            anim.Play("Shotanim");
            Myfx.PlayOneShot(ShotSFX);
        }
    }
}
