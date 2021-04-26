using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int enemyHealth;
    public bool isCreepy;
    private bool doOnce;
    public AudioSource audioSource;
    public AudioClip shotMe;

    public void TakeDamage(int damageTaken)
    {
        enemyHealth -= damageTaken;
        if (isCreepy && !doOnce)
        {
            audioSource.PlayOneShot(shotMe);
            doOnce = true;
        }

    }
}
