using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerManager : Singleton<FlowerManager>
{
    [SerializeField]
    private GameObject flowerPrefab;

    [SerializeField]
    private int numberOfProductions;

    [SerializeField]
    private int shelfCapacity;

    [SerializeField]
    private int stackCapacity;

    [SerializeField]
    private Vector3 productDesiredPosition;
    [SerializeField]
    private Vector3 stackDesiredPosition;
    [SerializeField]
    private Vector3 shelfDesiredPosition;

    private GameObject[] stackFlowers;
    private GameObject[] shelfFlowers;
    private GameObject[] productFlowers;
    private float timer = 2f;
    private int flowNum;

    void Start()
    {
        for (int i = 0; i < numberOfProductions; i++)
        {
            var flower = Instantiate(flowerPrefab, productDesiredPosition, Quaternion.identity);
            productFlowers[i] = flower;
            productFlowers[i].SetActive(false);
        }
        for (int i = 0; i < shelfCapacity; i++)
        {
            var flower = Instantiate(flowerPrefab, shelfDesiredPosition, Quaternion.identity);
            shelfFlowers[i] = flower;
            shelfFlowers[i].SetActive(false);
        }
        for (int i = 0; i < stackCapacity; i++)
        {
            var flower = Instantiate(flowerPrefab, stackDesiredPosition, Quaternion.identity);
            stackFlowers[i] = flower;
            stackFlowers[i].SetActive(false);
        }
        flowNum = numberOfProductions;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer == 0)
        {
            productFlowers[flowNum].SetActive(true);
            flowNum--;
            if (flowNum < 0)
                flowNum = numberOfProductions;
        }
    }
    public void AddStackFlower(int desiredFlowers)
    {
        for (int i = 0; i < desiredFlowers; i++)
        {
            stackFlowers[i].SetActive(true);
        }
    }
    // public void AddProductFlower(int desiredFlowers)
    // {
    //     for (int i = 0; i < desiredFlowers; i++)
    //     {
    //         productFlowers[i].SetActive(true);
    //     }
    // }
    public void AddShelfFlower(int desiredFlowers)
    {
        for (int i = 0; i < desiredFlowers; i++)
        {
            shelfFlowers[i].SetActive(true);
        }
    }

    public void RemoveStackFlower(int desiredFlowers)
    {
        for (int i = desiredFlowers; i <= 0; i--)
        {
            stackFlowers[i].SetActive(false);
        }
    }
    public void RemoveProductFlower(int desiredFlowers)
    {
        for (int i = desiredFlowers; i <= 0; i--)
        {
            productFlowers[i].SetActive(false);
        }
    }
    public void RemoveShelfFlower(int desiredFlowers)
    {
        for (int i = desiredFlowers; i <= 0; i--)
        {
            shelfFlowers[i].SetActive(false);
        }
    }

}
