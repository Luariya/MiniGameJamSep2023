using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonObject : MonoBehaviour
{

    public bool isPressed = false;
    public bool staysPressed = false;
    public ButtonConnection[] connections;
    public ParticleSystem particleSystemObject;
    public AudioClip buttonSound_pressed;
    public AudioClip buttonSound_released;

    SpriteRenderer spriteRenderer;

     Color unpressedColor = Color.red;
    public Color pressedColor = Color.green;


    public int weight = 0;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        unpressedColor = spriteRenderer.color;
    }

    // on trigger enter 2d
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger Enter");

            weight++;


        particleSystemObject.Play();

        spriteRenderer.color = pressedColor;
            isPressed = true;
            foreach (ButtonConnection connection in connections)
            {
                connection.Activate();
            }
        

            AudioBox.instance.PlayClip(buttonSound_pressed);
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

            AudioBox.instance.PlayClip(buttonSound_released);
        
    }

}
