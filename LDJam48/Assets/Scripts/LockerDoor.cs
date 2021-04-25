using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerDoor : MonoBehaviour
{

    public Animator lockerDoorAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("thePlayer") || other.CompareTag("Enemy"))
        {
            lockerDoorAnim.SetTrigger("Open");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("thePlayer") || other.CompareTag("Enemy"))
        {
            lockerDoorAnim.SetTrigger("Close");
        }
    }
}
