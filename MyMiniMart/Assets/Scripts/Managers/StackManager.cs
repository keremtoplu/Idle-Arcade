using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackManager : Singleton<StackManager>
{
    [SerializeField]
    private Vector3 distanceBetweenObject;

    [SerializeField]
    private Transform prevObject;
    [SerializeField]
    private Transform parent;
    [SerializeField]
    private Vector3 stackSize;

    public void PickUp(GameObject pickedObject)
    {
        pickedObject.transform.parent = parent;
        Vector3 desPos = prevObject.localPosition;
        for (int i = 0; i < stackSize.z; i++)
        {
            desPos.z += distanceBetweenObject.z;
            pickedObject.transform.localPosition = desPos;
            prevObject = pickedObject.transform;
        }
        for (int i = 0; i < stackSize.x; i++)
        {
            desPos.x += distanceBetweenObject.x;
            pickedObject.transform.localPosition = desPos;
            prevObject = pickedObject.transform;
        }
        for (int i = 0; i < stackSize.y; i++)
        {
            desPos.y += distanceBetweenObject.y;
            pickedObject.transform.localPosition = desPos;
            prevObject = pickedObject.transform;
        }

    }

    public void AlignStand()
    {

    }

}