using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTransition : MonoBehaviour
{
    public Animator animator;

    // make this instance a singleton
    public static LevelTransition instance;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
            animator.Play("GoOut");
    }

    public void FadeToLevel()
    {
        animator.Play("GoIn");
    }
}
