using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GoalPost[] goalPosts;
    // make this instance
    public static SceneController instance;

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
        LoadNextScene();

    }




    public void RestartScene()
    {
        // get current scene
        Scene currentScene = SceneManager.GetActiveScene();
        // get current scene index
        int currentSceneIndex = currentScene.buildIndex;
        // load current scene
        SceneManager.LoadScene(currentSceneIndex);


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
