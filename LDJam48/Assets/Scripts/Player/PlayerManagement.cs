using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManagement : MonoBehaviour
{

    public PlayerHealth playerHealth;
    public PlayerAmmo pistolAmmo;
    public PlayerAmmo aRAmmo;
    public Camera fpsCamera;
    public float interactRange;
    public GameObject elevatorInteractUI;
    public TextMeshProUGUI currentFloorUI;
    public Animator elevatorDoors;

    private bool pressingButton;


    // Start is called before the first frame update
    void Start()
    {
        pressingButton = false;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, interactRange))
        {
            //Debug.Log(hit.transform.name);
            if (hit.transform.tag == "Swiper")
            {
                elevatorInteractUI.SetActive(true);
            }
            else
            {
                elevatorInteractUI.SetActive(false);
            }
            if (hit.transform.tag == "Button")
            {
                ButtonManager button = hit.transform.GetComponent<ButtonManager>();
                if (button.isActivated && !pressingButton)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        pressingButton = true;
                        StartCoroutine(PressingAButton());
                        hit.transform.GetComponent<Animator>().SetTrigger("ButtonPressed");
                        StartCoroutine(PressingThisButton(button.buttonNumber));
                    }
                    
                }
                else
                {

                }
            }
            if(hit.transform.tag == "Keycard")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.transform.GetComponent<KeycardItemManager>().PickUpKeycard();
                }
            }

        }
        

    }

    IEnumerator PressingThisButton(int buttonNumber)
    {
        //Play Button Pressed Sound
        elevatorDoors.SetTrigger("CloseDoor");
        currentFloorUI.text = "Moving To: B" + buttonNumber;
        yield return new WaitForSeconds(3.5f);
        currentFloorUI.text = "Current Floor: B" + buttonNumber;
        elevatorDoors.SetTrigger("OpenDoor");
    }

    IEnumerator PressingAButton()
    {
        yield return new WaitForSeconds(1.2f);
        pressingButton = false;
    }
}
