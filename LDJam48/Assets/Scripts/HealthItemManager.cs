using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItemManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int healAmount;


    public void PickUpHealth()
    {
        playerHealth.Health += healAmount;
        if (playerHealth.Health > playerHealth.maxHealth)
        {
            playerHealth.Health = playerHealth.maxHealth;
        }
        Destroy(this.gameObject);
    }
}
