using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActivator : MonoBehaviour
{

    public Animator keycardAnimator;
    public List<ButtonManager> buttons = new List<ButtonManager>();


    public void ButtActivation()
    {
        int buttonToActivate = keycardAnimator.GetInteger("ButtonActivation");
        buttons[buttonToActivate - 1].ActivateButton();
    }

}
