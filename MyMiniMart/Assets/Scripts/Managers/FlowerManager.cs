using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerManager : Singleton<FlowerManager>
{
    [SerializeField]
    private GameObject productFlowerPrefab;

    [SerializeField]
    private Vector3 productDesiredPosition;

    [SerializeField]
    private Transform flowerParent;

    [SerializeField]
    private int flowerPrize;

    private int currentProductFlower;
    private int currentProductCapacity;
    private float timer = 0;
    private bool isCollect;

    public int CurrentProductCapacity
    {
        get { return currentProductCapacity; }
        set
        {
            currentProductCapacity += value;

        }
    }
    public int CurrentProductFlower
    {
        get { return currentProductFlower; }
        set
        {
            currentProductFlower += value;

        }
    }
    public bool IsCollect
    {
        get { return isCollect; }
        set
        {
            isCollect = value;

        }
    }
    public int FlowerPrize => flowerPrize;

    void Start()
    {
        currentProductFlower = 0;
        currentProductCapacity = 5;
        isCollect = true;
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            ProduceFlower();
            isCollect = true;
            timer = 2f;
        }

    }


    public void ProduceFlower()
    {
        if (!isCollect && currentProductFlower < currentProductCapacity)
        {
            Debug.Log(currentProductFlower);
            for (int i = 0; i < currentProductFlower; i++)
            {
                Debug.Log(currentProductFlower);
                var flower = Instantiate(productFlowerPrefab, new Vector3(productDesiredPosition.x + i, productDesiredPosition.y, productDesiredPosition.z), Quaternion.identity);
                flower.transform.parent = flowerParent;
                timer = 2f;
            }
            isCollect = true;
        }



    }
}


