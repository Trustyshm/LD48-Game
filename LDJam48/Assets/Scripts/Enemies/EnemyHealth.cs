using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int enemyHealth;

    public void TakeDamage(int damageTaken)
    {
        enemyHealth -= damageTaken;

    }
}
