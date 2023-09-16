using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelAuswahl : MonoBehaviour
{
    
    
    public void Level1Button()
    {

        SceneManager.LoadScene("Level1");

    }
    public void Level2Button()
    {

        SceneManager.LoadScene("Level2");

    }
}
