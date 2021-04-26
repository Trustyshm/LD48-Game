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

    public EnemyController enemyController;

    private bool activateOnce;
    public AIMovement caged1;
    public AIMovement caged2;
    public AIMovement caged3;

    public AudioSource audioSource;
    public AudioClip buttonPress;
    public AudioClip pickupItem;
    public AudioClip elevator2;
    public AudioClip elevator6;
    public AudioClip elevator10;
    public AudioClip elevator11;
    public AudioClip elevatorOpen;
    public AudioClip elevatorClose;
    public AudioClip lockerSound;
    public AudioClip barsOpen;

    // Start is called before the first frame update
    void Start()
    {
        pressingButton = false;
        Time.timeScale = 1;
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
                    audioSource.PlayOneShot(pickupItem);
                    hit.transform.GetComponent<KeycardItemManager>().PickUpKeycard();
                    itemInteractUI.SetActive(false);
                }
            }
           

            if (hit.transform.tag == "AmmoBox")
            {
                itemInteractUI.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    audioSource.PlayOneShot(pickupItem);
                    hit.transform.GetComponent<AmmoItemManager>().PickUpAmmo();
                    itemInteractUI.SetActive(false);
                }
            }


            if (hit.transform.tag == "HealthBox")
            {
                itemInteractUI.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    audioSource.PlayOneShot(pickupItem);
                    hit.transform.GetComponent<HealthItemManager>().PickUpHealth();
                    itemInteractUI.SetActive(false);
                }
            }


            if (hit.transform.tag == "ALocker")
            {
                itemInteractUI.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    audioSource.PlayOneShot(lockerSound);
                    hit.transform.parent.GetComponentInParent<Animator>().SetTrigger("Open");
                }
            }


            if (hit.transform.tag == "CellButton")
            {
                itemInteractUI.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    audioSource.PlayOneShot(buttonPress);
                    audioSource.PlayOneShot(barsOpen);
                    hit.transform.parent.GetComponentInParent<Animator>().SetTrigger("Open");
                    if (!activateOnce)
                    {
                        caged1.enabled = true;
                        caged2.enabled = true;
                        caged3.enabled = true;
                        activateOnce = true;
                    }
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
        audioSource.PlayOneShot(elevatorClose);
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
            audioSource.PlayOneShot(elevator2);
            yield return new WaitForSeconds(2.5f);
        }
        if (buttonNumber == 3)
        {
            audioSource.PlayOneShot(elevator6);
            yield return new WaitForSeconds(6.0f);
        }
        if (buttonNumber == 4)
        {
            audioSource.PlayOneShot(elevator10);
            yield return new WaitForSeconds(10.2f);
        }

        if (buttonNumber == 5)
        {
            audioSource.PlayOneShot(elevator11);
            yield return new WaitForSeconds(11.6f);
        }
        if (buttonNumber == 1)
        {
            enemyController.ActivateB1();
        }
        if (buttonNumber == 2)
        {
            enemyController.ActivateB2();
        }
        if (buttonNumber == 3)
        {
            enemyController.ActivateB3();
        }
        if (buttonNumber == 4)
        {
            enemyController.ActivateB4();
        }
        if (buttonNumber == 5)
        {
            enemyController.ActivateB5();
        }

        currentFloorUI.text = "Current Floor: B" + buttonNumber;
            elevatorDoors.SetTrigger("OpenDoor");
        audioSource.PlayOneShot(elevatorOpen);


    }
    
    IEnumerator PressingAButton()
    {
        yield return new WaitForSeconds(1.2f);
        pressingButton = false;
    }
}
