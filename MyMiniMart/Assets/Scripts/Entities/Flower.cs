using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour, ICollectable
{

    private void Awake()
    {

    }
    public void Expand()
    {
        PlayerController.Instance.Stack.AddStack(gameObject);
    }

}
