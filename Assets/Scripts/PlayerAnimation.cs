using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerAnimation : MonoBehaviour
{
    public UnityEvent eventFinishAnimation;
    public void ActivePlayer()
    {
        eventFinishAnimation.Invoke();
    }
    
}
