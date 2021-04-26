using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public GameObject pauseMenu;
    private bool toggleBool;
    public GameObject elevatorMenu;
    public FirstPersonLook playerLook;
    public FirstPersonMovement playerMovement;
    public GunManager playerGun;
    public CharacterController playerController;
    public GameObject deathMenu;

    public GameObject settingsMenu;


    void Start()
    {
    }

    void Update()
    {

        if (deathMenu.activeInHierarchy)
        {

        }

        else
        {
            if (!settingsMenu.activeInHierarchy)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    TogglePause();
                }
            }
            

            if (toggleBool)
            {

                playerGun.enabled = false;

                playerLook.isActive = false;
                playerController.Move(new Vector3(0, 0, 0));
                playerController.velocity.Set(0, 0, 0);
                //playerMovement.isActive = false;
                Cursor.lockState = CursorLockMode.None;
            }

            if (!toggleBool)
            {
                if (elevatorMenu.activeInHierarchy == true)
                {

                }
                else
                {
                    Cursor.lockState = CursorLockMode.Locked;
                    playerGun.enabled = true;
                    playerMovement.isActive = true;
                    playerLook.isActive = true;
                }
            }
        }

        
    }

    public void OpenMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void RestartScene()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void TogglePause()
    {
        toggleBool = !toggleBool;
        pauseMenu.SetActive(toggleBool);

    }

    public void ClosePause()
    {
        if (!settingsMenu.activeInHierarchy)
        {
            TogglePause();
        }
        
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void OpenSettings()
    {
        settingsMenu.SetActive(true);
    }

}
