using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyclopsHealth : MonoBehaviour
{
    public int enemyHealth;
    public GameObject tentOne;
    public GameObject tentTwo;
    public GameObject tentThree;
    public GameObject eyeball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (enemyHealth <= 0)
        {
            enemyHealth = 0;
            Destroy(tentOne);
            Destroy(tentTwo);
            Destroy(tentThree);
            Destroy(eyeball);
            Destroy(this.gameObject);

        }
        
    }

    public void TakeDamage(int damageTaken)
    {
        enemyHealth -= damageTaken;
    }
}
