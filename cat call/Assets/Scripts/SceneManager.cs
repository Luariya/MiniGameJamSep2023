using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public GoalPost[] goalPosts;
    // make this instance
    public static SceneManager instance;

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

        Debug.Log("You win!");
    }

    


    public void RestartScene()
    {
        
        
    }

    public void LoadNextScene()
    {
        
    }
}
