using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerStats : MonoBehaviour
{

    public PlayerAmmo playerAmmo;
    public PlayerHealth playerHealth;

    public Image healthBar;
    public TextMeshProUGUI ammoText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ammoText.text = playerAmmo.currentAmmo.ToString();

        healthBar.fillAmount = (float)playerHealth.Health / (float)playerHealth.maxHealth;
    }
}
