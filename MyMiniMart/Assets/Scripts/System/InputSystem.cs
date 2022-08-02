using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : Singleton<InputSystem>
{

    public event Action Touch;
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch?.Invoke();
        }
        else
            PlayerController.Instance.makeAnimationIdle();
    }
}
