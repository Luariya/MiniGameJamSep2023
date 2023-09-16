using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{


    public void QuitButton()
    {
       
        Debug.Log("Quit");
        Application.Quit();

    }

    public void StartButton()
    {
        
        SceneManager.LoadScene("Level1");

    }

    public void LevelButton()
    {

        SceneManager.LoadScene("LevelSelect");

    }
}
