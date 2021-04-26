using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoItemManager : MonoBehaviour
{
    public PlayerAmmo playerAmmo;
    public int ammoAmount;


    public void PickUpAmmo()
    {
        playerAmmo.currentAmmo += ammoAmount;
        if (playerAmmo.currentAmmo > playerAmmo.maximumAmmo)
        {
            playerAmmo.currentAmmo = playerAmmo.maximumAmmo;
        }
        Destroy(this.gameObject);
    }
}
