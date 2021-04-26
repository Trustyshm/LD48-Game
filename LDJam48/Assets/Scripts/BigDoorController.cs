using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigDoorController : MonoBehaviour
{

    public Animator doorAnimator;
    public AudioSource audioSource;
    public AudioClip doorOpen;

    private bool doOnce;

    public void OnTriggerEnter(Collider other)
    {
        if (!doOnce)
        {
            doorAnimator.SetTrigger("Open");
            audioSource.PlayOneShot(doorOpen);
            doOnce = true;
        }
        
    }
}
