using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorInteract : MonoBehaviour
{

    public GameObject cardSelectUI;
    public GameObject crosshairUI;
    public FirstPersonLook firstPersonLook;
    public FirstPersonMovement playerMovement;
    public GunManager pistolManager;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            cardSelectUI.SetActive(true);
            firstPersonLook.isActive = false;
            playerMovement.isActive = false;
            pistolManager.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            crosshairUI.SetActive(false);
            this.gameObject.SetActive(false);
            //Play Open Sound
        }
    }
}
