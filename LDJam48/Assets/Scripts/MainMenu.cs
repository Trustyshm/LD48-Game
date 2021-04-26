using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject settingsMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGametScene()
    {
        SceneManager.LoadScene("MainLevel");
    }


    public void ExitGame()
    {
        Application.Quit();
    }

    public void OpenSettings()
    {
        settingsMenu.SetActive(true);
    }
}
