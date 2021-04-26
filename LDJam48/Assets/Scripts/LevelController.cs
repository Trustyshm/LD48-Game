using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{

    public GameObject elevator;
    public GameObject player;
    private bool goToOne;
    public float speed;

    private bool doneOnceOne;
    private bool doneOnceTwo;
    private bool doneOnceThree;
    private bool doneOnceFour;
    private bool doneOnceFive;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (goToOne)
        {
            elevator.transform.position = Vector3.Lerp(elevator.transform.position, new Vector3(elevator.transform.position.x, elevator.transform.position.y - 6.727f, elevator.transform.position.z), speed * Time.deltaTime);
        }


    }

    public void GotoBOne()
    {
        if (!doneOnceOne)
        {
            StartCoroutine(GoToB1());
            doneOnceOne = true;
        }
            
    }

    IEnumerator GoToB1()
    {
        goToOne = true;
        yield return new WaitForSeconds(2f);
        goToOne = false;
    }

    public void GotoBTwo()
    {
        if (!doneOnceTwo)
        {
            StartCoroutine(GoToB2());
            doneOnceTwo = true;
        }
        
    }

    IEnumerator GoToB2()
    {
        goToOne = true;
        yield return new WaitForSeconds(1.2f);
        goToOne = false;
    }

    public void GotoBThree()
    {
        if (!doneOnceThree)
        {
            StartCoroutine(GoToB3());
            doneOnceThree = true;
        }
        
    }

    IEnumerator GoToB3()
    {
        goToOne = true;
        yield return new WaitForSeconds(5.8f);
        goToOne = false;
    }

    public void GotoBFour()
    {
        if (!doneOnceFour)
        {
            StartCoroutine(GoToB4());
            doneOnceFour = true;
        }
        
    }

    IEnumerator GoToB4()
    {
        goToOne = true;
        yield return new WaitForSeconds(7.9f);
        goToOne = false;
    }

    public void GotoBFive()
    {
        if (!doneOnceFive)
        {
            StartCoroutine(GoToB5());
            doneOnceFive = true;
        }
        
    }

    IEnumerator GoToB5()
    {
        goToOne = true;
        yield return new WaitForSeconds(11.5f);
        goToOne = false;
    }
}
