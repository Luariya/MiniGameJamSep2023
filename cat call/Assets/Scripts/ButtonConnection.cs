using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonConnection : MonoBehaviour
{


    public bool isAvtivated = false;

    public virtual void Activate()
    {
        isAvtivated = true;
    }

    public virtual void Deactivate()
    {
        isAvtivated = false;
    }
}
