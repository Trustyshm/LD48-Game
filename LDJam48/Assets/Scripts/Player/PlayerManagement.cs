using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManagement : MonoBehaviour
{

    public LevelController levelController;

    public PlayerHealth playerHealth;
    public PlayerAmmo pistolAmmo;
    public PlayerAmmo aRAmmo;
    public Camera fpsCamera;
    public float interactRange;
    public GameObject elevatorInteractUI;
    public TextMeshProUGUI currentFloorUI;
    public Animator elevatorDoors;

    public GameObject itemInteractUI;

    private bool pressingButton;

    private List<int> levelsUsed = new List<int>();


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
                    itemInteractUI.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        pressingButton = true;
                        StartCoroutine(PressingAButton());
                        hit.transform.GetComponent<Animator>().SetTrigger("ButtonPressed");
                        if (levelsUsed.Contains(button.buttonNumber))
                        {

                        }
                        else
                        {
                            StartCoroutine(PressingThisButton(button.buttonNumber));
                        }
                        
                    }
                    
                }
                else
                {

                }
            }

            if(hit.transform.tag == "Keycard")
            {
                itemInteractUI.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.transform.GetComponent<KeycardItemManager>().PickUpKeycard();
                    itemInteractUI.SetActive(false);
                }
            }
           

            if (hit.transform.tag == "AmmoBox")
            {
                itemInteractUI.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.transform.GetComponent<AmmoItemManager>().PickUpAmmo();
                    itemInteractUI.SetActive(false);
                }
            }


            if (hit.transform.tag == "HealthBox")
            {
                itemInteractUI.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.transform.GetComponent<HealthItemManager>().PickUpHealth();
                    itemInteractUI.SetActive(false);
                }
            }


            if (hit.transform.tag == "ALocker")
            {
                itemInteractUI.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.transform.parent.GetComponentInParent<Animator>().SetTrigger("Open");
                }
            }


            if (hit.transform.tag == "CellButton")
            {
                itemInteractUI.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.transform.parent.GetComponentInParent<Animator>().SetTrigger("Open");
                }
            }

            if (hit.transform.tag != "Keycard" && hit.transform.tag != "AmmoBox" && hit.transform.tag != "HealthBox" && hit.transform.tag != "ALocker" && hit.transform.tag != "CellButton" && hit.transform.tag != "Button")
            {
                itemInteractUI.SetActive(false);
            }

           
            

        }
        

    }

    IEnumerator PressingThisButton(int buttonNumber)
    {
        //Play Button Pressed Sound

        elevatorDoors.SetTrigger("CloseDoor");
        currentFloorUI.text = "Moving To: B" + buttonNumber;
        
        
        yield return new WaitForSeconds(1.5f);
        if (buttonNumber == 1)
        {
            levelController.GotoBOne();
            levelsUsed.Add(1);
        }
        if (buttonNumber == 2)
        {
            levelController.GotoBTwo();
            levelsUsed.Add(2);
        }
        if (buttonNumber == 3)
        {
            levelController.GotoBThree();
            levelsUsed.Add(3);
        }
        if (buttonNumber == 4)
        {
            levelController.GotoBFour();
            levelsUsed.Add(4);
        }

        if (buttonNumber == 5)
        {
            levelController.GotoBFive();
            levelsUsed.Add(5);
        }

        if (buttonNumber == 1 || buttonNumber == 2)
        {
            yield return new WaitForSeconds(2.5f);
        }
        if (buttonNumber == 3)
        {
            yield return new WaitForSeconds(6.0f);
        }
        if (buttonNumber == 4)
        {
            yield return new WaitForSeconds(10.2f);
        }

        if (buttonNumber == 5)
        {
            yield return new WaitForSeconds(11.6f);
        }

            currentFloorUI.text = "Current Floor: B" + buttonNumber;
            elevatorDoors.SetTrigger("OpenDoor");
        
        
    }
    
    IEnumerator PressingAButton()
    {
        yield return new WaitForSeconds(1.2f);
        pressingButton = false;
    }
}
