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

    private int currentProductFlower;
    private int currentProductCapacity;
    private float timer = 0;
    private bool isCollect = true;

    public bool IsCollect => isCollect;

    public int CurrentProductCapacity
    {
        get { return currentProductCapacity; }
        set
        {
            currentProductCapacity += value;

        }
    }

    void Start()
    {
        currentProductFlower = 0;
        currentProductCapacity = 1;
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            FlowerManager.Instance.ProduceFlower();
            timer = 2f;
        }

    }


    public void ProduceFlower()

    {
        if (isCollect && currentProductFlower < currentProductCapacity)
        {

            var flower = Instantiate(productFlowerPrefab, productDesiredPosition, Quaternion.identity);
            flower.transform.parent = flowerParent;
            currentProductFlower++;
            productDesiredPosition.x += 1;
            timer = 2f;
        }



    }
}


