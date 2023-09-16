using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonObject : MonoBehaviour
{

    public bool isPressed = false;
    public bool staysPressed = false;
    public ButtonConnection[] connections;

    SpriteRenderer spriteRenderer;

    public Color unpressedColor = Color.red;
    public Color pressedColor = Color.green;


    public int weight = 0;

    // on trigger enter 2d
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger Enter");

            weight++;

        spriteRenderer.color = pressedColor;
            isPressed = true;
            foreach (ButtonConnection connection in connections)
            {
                connection.Activate();
            }
        
    }

    // on trigger exit 2d
    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Trigger Exit");

        if(staysPressed)return;

        spriteRenderer.color = unpressedColor;


            weight--;
            if (weight > 0)
            {
                return;
            }
            isPressed = false;
            foreach (ButtonConnection connection in connections)
            {
                connection.Deactivate();
            }
        
    }

}
