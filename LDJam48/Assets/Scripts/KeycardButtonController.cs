using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeycardButtonController : MonoBehaviour
{

    public GameObject hoverBackground;
    public GameObject crosshairUI;
    public Animator keycardAnimator;
    public int keycardNumber;
    public GameObject keycardInventory;

    public ElevatorMainScreen elevatorMainScreenUI;

    public FirstPersonLook firstPersonLook;
    public FirstPersonMovement playerMovement;
    public GunManager pistolManager;

    public void MouseOver()
    {
        hoverBackground.GetComponent<Image>().enabled = true;
    }

    public void MouseEscape()
    {
        hoverBackground.GetComponent<Image>().enabled =false;
    }

    public void WasClicked()
    {
        StartCoroutine(ClickedButton());
    }

    IEnumerator ClickedButton()
    {
        //Play Click Sound
        hoverBackground.GetComponent<Image>().color = Color.green;
        yield return new WaitForSeconds(0.2f);
        hoverBackground.GetComponent<Image>().color = Color.red;
        keycardAnimator.SetTrigger("SwipeCard");
        keycardAnimator.SetInteger("ButtonActivation", keycardNumber);
        crosshairUI.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        if (keycardNumber == 1)
        {
            elevatorMainScreenUI.FirstSwipe();
        }
        if (keycardNumber == 2)
        {
            elevatorMainScreenUI.SecondSwipe();
        }
        firstPersonLook.isActive = true;
        playerMovement.isActive = true;
        pistolManager.enabled = true;
        hoverBackground.GetComponent<Image>().color = Color.green;
        keycardInventory.SetActive(false);
    }

}
