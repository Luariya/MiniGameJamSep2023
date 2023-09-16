using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonObject : MonoBehaviour
{

    public bool isPressed = false;
    public ButtonConnection[] connections;


    public int weight = 0;

    // on trigger enter 2d
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger Enter");

            weight++;

            isPressed = true;
            foreach (ButtonConnection connection in connections)
            {
                connection.Activate();
            }
        
    }

    // on trigger exit 2d
    private void OnTriggerExit2D(Collider2D other)
    {



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
