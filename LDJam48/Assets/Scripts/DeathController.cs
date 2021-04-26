using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathController : MonoBehaviour
{

    public FirstPersonLook playerLook;
    public FirstPersonMovement playerMove;
    public GunManager playerGun;
    public CharacterController playerController;
    public PlayerHealth playerHealth;
    public GameObject deathMenu;

    // Start is called before the first frame update
    void Start()
    {
        //Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (playerHealth.Health <= 0)
        {
            playerController.enabled = false;
            playerLook.enabled = false;
            playerMove.enabled = false;
            playerGun.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
            deathMenu.SetActive(true);
        }

    }
}
