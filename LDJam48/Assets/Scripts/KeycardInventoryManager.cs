using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeycardInventoryManager : MonoBehaviour
{

    public KeycardInventory keycardInventory;
    public List<GameObject> keycards;
    public GameObject noKeycards;

    public GameObject crosshairUI;
    public FirstPersonLook playerLook;
    public GunManager pistolManager;
    public FirstPersonMovement playerMovement;
    public GameObject theUI;


    // Start is called before the first frame update
    void Start()
    {
        noKeycards.SetActive(true);
        foreach (GameObject keycard in keycards)
        {
            keycard.SetActive(false);
        }
        keycardInventory.KeycardOne = false;
        keycardInventory.KeycardTwo = false;
        keycardInventory.KeycardThree = false;
        keycardInventory.KeycardFour = false;
        keycardInventory.KeycardFive = false;
        HandleKeycards();
    }

    private void Awake()
    {
        HandleKeycards();
    }


    public void HandleKeycards()
    {
        if (!keycardInventory.KeycardOne)
        {
            noKeycards.SetActive(true);
            foreach (GameObject keycard in keycards)
            {
                keycard.SetActive(false);
            }
        }

        if (keycardInventory.KeycardOne)
        {
            noKeycards.SetActive(false);
            keycards[0].SetActive(true);
        }
        if (keycardInventory.KeycardTwo)
        {
            keycards[1].SetActive(true);
        }
        if (keycardInventory.KeycardThree)
        {
            keycards[2].SetActive(true);
        }
        if (keycardInventory.KeycardFour)
        {
            keycards[3].SetActive(true);
        }
        if (keycardInventory.KeycardFive)
        {
            keycards[4].SetActive(true);
        }
    }

    public void CloseWindow()
    {
        playerLook.isActive = true;
        playerMovement.isActive = true;
        pistolManager.enabled = true;
        crosshairUI.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        theUI.SetActive(false);
    }

}
