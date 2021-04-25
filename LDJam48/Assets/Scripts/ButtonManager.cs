using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ButtonManager : MonoBehaviour
{

    public bool isActivated;
    private Renderer buttonMaterial;
    private Animator buttonAnimator;
    public int buttonNumber;
    

    // Start is called before the first frame update
    void Start()
    {
        isActivated = false;
        buttonMaterial = this.GetComponent<Renderer>();
        buttonAnimator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateButton()
    {
        if (!isActivated)
        {
            buttonMaterial.material.SetColor("_Color", Color.green);
            isActivated = true;
        }
        
    }

    public void PressButton()
    {
        if (isActivated)
        {
            buttonAnimator.SetTrigger("PressButton");
            //Play pressed sound
        }
        else
        {
            //Play error sound
        }
        
    }



}
