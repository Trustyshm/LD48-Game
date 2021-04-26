using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject B1enemys;
    public GameObject B2enemys;
    public GameObject B3enemys;
    public GameObject B4enemys;
    public GameObject B5enemys;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateB1()
    {
        B1enemys.SetActive(true);

    }
    public void ActivateB2()
    {
        B2enemys.SetActive(true);

    }
    public void ActivateB3()
    {
        B3enemys.SetActive(true);
        

    }
    public void ActivateB4()
    {
        B4enemys.SetActive(true);

    }

    public void ActivateB5()
    {
        B5enemys.SetActive(true);

    }
}
