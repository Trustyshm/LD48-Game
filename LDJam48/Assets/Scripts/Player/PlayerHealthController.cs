using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{

    public PlayerHealth playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth.Health = 30;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth.Health <= 0)
        {
            playerHealth.Health = 0;
            PlayerDies();
        }
    }

    public void TakeDamage(int damage)
    {
        playerHealth.Health -= damage;
    }

    private void PlayerDies()
    {
        Debug.Log("You Died");
    }

}
