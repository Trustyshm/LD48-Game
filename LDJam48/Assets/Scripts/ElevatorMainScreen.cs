using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ElevatorMainScreen : MonoBehaviour
{
    private TextMeshProUGUI screenText;

    // Start is called before the first frame update
    void Start()
    {
        screenText = GetComponent<TextMeshProUGUI>();
        screenText.text = "Warning: \n  \n Facility Lockdown \n Please Swipe Access Card";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FirstSwipe()
    {
        StartCoroutine(SwipeSequence());
    }

    IEnumerator SwipeSequence()
    {
        screenText.text = "...Processing";
        yield return new WaitForSeconds(1.5f);
        screenText.text = "Success! \n Floor Unlocked";
        yield return new WaitForSeconds(1.5f);
        screenText.text =
            "Floor Access: \n " +
            "B1: Unlocked \n " +
            "B2: Locked* \n " +
            "B3: Locked* \n " +
            "B4: Locked* \n " +
            "B5: Locked* \n" +
            "*[Please Insert Access Card] ";
    }

    public void SecondSwipe()
    {
        StartCoroutine(SecondSwipeSequence());
    }

    IEnumerator SecondSwipeSequence()
    {
        screenText.text = "...Processing";
        yield return new WaitForSeconds(1.5f);
        screenText.text = "Success! \n Floor Unlocked";
        yield return new WaitForSeconds(1.5f);
        screenText.text =
            "Floor Access: \n " +
            "B1: Unlocked \n " +
            "B2: Unlocked \n " +
            "B3: Locked* \n " +
            "B4: Locked* \n " +
            "B5: Locked* \n" +
            "*[Please Insert Access Card] ";
    }

    public void ThirdSwipe()
    {
        StartCoroutine(ThirdSwipeSequence());
    }

    IEnumerator ThirdSwipeSequence()
    {
        screenText.text = "...Processing";
        yield return new WaitForSeconds(1.5f);
        screenText.text = "Success! \n Floor Unlocked";
        yield return new WaitForSeconds(1.5f);
        screenText.text =
            "Floor Access: \n " +
            "B1: Unlocked \n " +
            "B2: Unlocked \n " +
            "B3: Unlocked \n " +
            "B4: Locked* \n " +
            "B5: Locked* \n" +
            "*[Please Insert Access Card] ";
    }

    public void FourthSwipe()
    {
        StartCoroutine(FourthSwipeSequence());
    }

    IEnumerator FourthSwipeSequence()
    {
        screenText.text = "...Processing";
        yield return new WaitForSeconds(1.5f);
        screenText.text = "Success! \n Floor Unlocked";
        yield return new WaitForSeconds(1.5f);
        screenText.text =
            "Floor Access: \n " +
            "B1: Unlocked \n " +
            "B2: Unlocked \n " +
            "B3: Unlocked \n " +
            "B4: Unlocked \n " +
            "B5: Locked* \n" +
            "*[Please Insert Access Card] ";
    }

    public void FifthSwipe()
    {
        StartCoroutine(FifthSwipeSequence());
    }

    IEnumerator FifthSwipeSequence()
    {
        screenText.text = "...Processing";
        yield return new WaitForSeconds(1.5f);
        screenText.text = "Success! \n Floor Unlocked";
        yield return new WaitForSeconds(1.5f);
        screenText.text =
            "Floor Access: \n " +
            "B1: Unlocked \n " +
            "B2: Unlocked \n " +
            "B3: Unlocked \n " +
            "B4: Unlocked \n " +
            "B5: Unlocked \n" +
            "[ All levels unlocked. ] ";
    }
}
