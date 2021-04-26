using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryMenu : MonoBehaviour
{

    public GameObject victoryMenu;
    public EnemyHealth health;
    public FirstPersonLook playerLook;
    public FirstPersonMovement playerMove;
    public GunManager gunthing;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (health.enemyHealth <= 0)
        {
            victoryMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            playerLook.isActive = false;
            playerMove.isActive = false;
            gunthing.enabled = false;
        }
    }
}
