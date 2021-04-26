using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrisonerLine : MonoBehaviour
{
    private bool doOnce;
    public AudioSource audioSource;
    public AudioClip prisonerLine;


    public void OnTriggerEnter(Collider other)
    {
        if (!doOnce)
        {
            audioSource.PlayOneShot(prisonerLine);
            doOnce = true;
        }
    }
}
