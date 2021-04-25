using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeycardItemManager : MonoBehaviour
{

    public KeycardInventory keycardInventory;
    public int keycardNumber;
    private KeycardInventoryManager keycardInventoryManager;

    // Start is called before the first frame update
   

    private void Awake()
    {
        keycardInventoryManager = GameObject.FindGameObjectWithTag("KeycardInventoryManager").GetComponent<KeycardInventoryManager>();
    }

    void Start()
    {

        //GameObject.FindGameObjectWithTag("KeycardInventoryManager").SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PickUpKeycard()
    {
        if (keycardNumber == 1)
        {
            keycardInventory.KeycardOne = true;
            keycardInventoryManager.HandleKeycards();

        }
        if (keycardNumber == 2)
        {
            keycardInventory.KeycardTwo = true;
            keycardInventoryManager.HandleKeycards();
        }
        if (keycardNumber == 3)
        {
            keycardInventory.KeycardThree = true;
            keycardInventoryManager.HandleKeycards();
        }
        if (keycardNumber == 4)
        {
            keycardInventory.KeycardFour = true;
            keycardInventoryManager.HandleKeycards();
        }
        if (keycardNumber == 5)
        {
            keycardInventory.KeycardFive = true;
            keycardInventoryManager.HandleKeycards();
        }
        keycardInventoryManager.HandleKeycards();
        //Play Pickup Sound
        Destroy(this.gameObject);

    }
}
