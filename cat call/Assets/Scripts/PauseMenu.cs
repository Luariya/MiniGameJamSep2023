using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool Paused = false;

    public GameObject pauseMenuUI;

    private void Start()
    {
        Resume();
    }



    private void Update()
    {
        // if escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape)|| Input.GetKeyDown(KeyCode.P))
        {
            // if game is paused
            if (Paused)
            {
                // unpause game
                Resume();
            }
            // if game is not paused
            else
            {
                // pause game
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        // set time scale to 1
        Time.timeScale = 1f;
        // set paused to false
        Paused = false;
        // disable pause menu

    }

    public void Pause()
    {

        pauseMenuUI.SetActive(true);
        // set time scale to 0
        Time.timeScale = 0f;
        // set paused to true
        Paused = true;
        // enable pause menu
    }
}
