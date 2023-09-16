using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject Men�;
    public GameObject LevelSelect;

    public void QuitButton()
    {
        
        Debug.Log("Quit");
        Application.Quit();

    }

    public void StartButton()
    {
        
        SceneManager.LoadScene("Level1");

    }

    public void LevelScreen()
    {
       
        LevelSelect.SetActive(true);
        Men�.SetActive(false);

    }
    public void Men�Screen()
    {

        LevelSelect.SetActive(false);
        Men�.SetActive(true);

    }
}
