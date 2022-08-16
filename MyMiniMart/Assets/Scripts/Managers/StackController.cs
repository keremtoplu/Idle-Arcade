using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackController : MonoBehaviour
{
    [SerializeField]
    private int xLen, yLen, zLen;

    [SerializeField]
    private int stackCapacity;

    [SerializeField]
    private Vector3 stackSizeOffset;
    private Transform[] itemPositions;

    public int MaxCapacity => xLen * yLen * zLen;

    private int itemCount = 0;

    private List<GameObject> items = new List<GameObject>();

    public int StackCapacity => stackCapacity;
    public int ItemCount => itemCount;
    private void Start()
    {
        GenerateItemPositions();
    }

    private void GenerateItemPositions()
    {
        if (stackSizeOffset.x == 0f || stackSizeOffset.y == 0f || stackSizeOffset.z == 0f)
        {
            Debug.LogError("Stack offset cannot be 0");
            return;
        }

        itemPositions = new Transform[MaxCapacity];
        int itemCounter = 0;

        for (int i = 0; i < yLen; i++)
        {
            for (int j = 0; j < zLen; j++)
            {
                for (int k = 0; k < xLen; k++)
                {
                    var pointObject = new GameObject($"position {k} {j} {i}");
                    var pointTransform = pointObject.transform;
                    pointObject.transform.SetParent(transform);

                    pointTransform.localPosition = new Vector3(k * stackSizeOffset.x, i * stackSizeOffset.y, j * stackSizeOffset.z);
                    itemPositions[itemCounter++] = pointTransform;
                }
            }
        }
    }

    public void AddStack(GameObject pickedObject)
    {
        if (stackCapacity >= itemCount)
        {
            pickedObject.transform.SetParent(itemPositions[itemCount]);
            pickedObject.transform.localPosition = new Vector3(0, 0, 0);
            //leantween eklenecek
            items.Add(pickedObject);
            FlowerManager.Instance.IsCollect = false;
            itemCount++;
            Debug.Log(itemCount);
        }
        else
            return;
    }

    public GameObject RemoveStack()
    {

        var removedItem = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        itemCount--;
        return removedItem;
    }

}
