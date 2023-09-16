using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GoalPost[] goalPosts;
    // make this instance
    public static SceneController instance;
    public float restartDelay = 1f;
    public float nextLevelDelay = 1f;

    public AudioClip audioClipWin;

    // Start is called before the first frame update
    void Start()
    {
        // set this instance
        instance = this;
    }


    public void CheckIfGoal()
    {
        foreach (GoalPost goalPost in goalPosts)
        {
            if (!goalPost.catInGoal)
            {
                return;
            }
        }
        Win();
    }

    public void Win()
    {
        Debug.Log("You win!");

        // fade to next scene
        LevelTransition.instance.FadeToLevel();
        AudioBox.instance.PlayClip(audioClipWin);

        // load next scene
        StartCoroutine(LoadNextSceneCoroutine());
       

    }

    // ienumerator for restarting scene
    IEnumerator RestartSceneCoroutine()
    {
        // wait for restart delay
        yield return new WaitForSeconds(restartDelay);
        // restart scene
        
        Scene currentScene = SceneManager.GetActiveScene();
        // get current scene index
        int currentSceneIndex = currentScene.buildIndex;
        // load current scene
        SceneManager.LoadScene(currentSceneIndex);
    }




    public void RestartScene()
    {
        // get current scene
        // start enumerator
        StartCoroutine(RestartSceneCoroutine());


    }


    // ienumerator for loading next scene
    IEnumerator LoadNextSceneCoroutine()
    {

        LevelTransition.instance.FadeToLevel();
        // wait for next level delay
        yield return new WaitForSeconds(nextLevelDelay);
        // load next scene
        LoadNextScene();
    }

    // enumerator for loading main menu
    IEnumerator LoadMainMenuCoroutine()
    {
        LevelTransition.instance.FadeToLevel();
        // wait for next level delay
        yield return new WaitForSeconds(nextLevelDelay);
        // load next scene
        MainMenu();
    }

    public void MainMenu()
    {
        // load main menu
        SceneManager.LoadScene(0);
    }

    public void LoadNextScene()
    {
        // get current scene
        Scene currentScene = SceneManager.GetActiveScene();
        // get current scene index
        int currentSceneIndex = currentScene.buildIndex;

        // if current scene index is the last scene
        if (currentSceneIndex == SceneManager.sceneCountInBuildSettings - 1)
        {
            // load first scene
            Debug.Log("You win!");
            return;
        }
        // load next scene
        SceneManager.LoadScene(currentSceneIndex + 1);



    }
}
