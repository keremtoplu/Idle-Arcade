using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Singleton<PlayerController>
{
    private void Start()
    {
        InputSystem.Instance.Touch += OnTouch;
    }
    private void OnTriggerEnter(Collider other)
    {
        var collectable = other.GetComponent<ICollectable>();
        if (collectable != null)
        {
            collectable.Expand();
        }
    }

    public void makeAnimationIdle()
    {
        transform.GetComponent<Animator>().SetTrigger("Idle");
    }
    private void OnTouch()
    {
        transform.GetComponent<Animator>().SetTrigger("Run");
    }
}
