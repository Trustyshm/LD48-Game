using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigDoorController : MonoBehaviour
{

    public Animator doorAnimator;

    public void OnTriggerEnter(Collider other)
    {
        doorAnimator.SetTrigger("Open");
    }
}
