using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalPost : MonoBehaviour
{
    public bool catInGoal = false;

    public SpriteRenderer spriteRenderer;
     Sprite goalPostSpriteDeactivated;
    public Sprite goalPostSpriteActivated;

    // ontrigger enter 2d


    public void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        goalPostSpriteDeactivated = spriteRenderer.sprite;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if the collision is a ball

        // set is activated to true
        catInGoal = true;
        spriteRenderer.sprite = goalPostSpriteActivated;
        // check if goal
        SceneController.instance.CheckIfGoal();

    }

    // ontrigger exit 2d
    private void OnTriggerExit2D(Collider2D collision)
    {
        // if the collision is a ball

        // set is activated to false
        spriteRenderer.sprite = goalPostSpriteDeactivated;
        catInGoal = false;

    }


}