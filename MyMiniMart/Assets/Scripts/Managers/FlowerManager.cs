using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerManager : Singleton<FlowerManager>
{
    [SerializeField]
    private GameObject shelfFlowerPrefab;
    [SerializeField]
    private GameObject productFlowerPrefab;

    [SerializeField]
    private GameObject handFlowerPrefab;

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

    [SerializeField]
    private GameObject player;

    private GameObject[] stackFlowers;
    private GameObject[] shelfFlowers;
    private GameObject[] productFlowers;

    private int currentShelfFlower;
    private int currentStackFlower;
    private int currentProductFlower;

    public int CurrentProductFlower => currentProductFlower;
    public int CurrentStackFlower => currentStackFlower;

    void Start()
    {
        stackFlowers = new GameObject[stackCapacity];
        shelfFlowers = new GameObject[shelfCapacity];
        productFlowers = new GameObject[numberOfProductions];

        currentProductFlower = 0;
        currentShelfFlower = 0;
        currentProductFlower = 0;

        for (int i = 0; i < numberOfProductions; i++)
        {
            var flower = Instantiate(productFlowerPrefab, productDesiredPosition + new Vector3(i, 0, 0), Quaternion.identity);
            productFlowers[i] = flower;
            productFlowers[i].SetActive(false);
        }
        for (int i = 0; i < shelfCapacity; i++)
        {
            var flower = Instantiate(shelfFlowerPrefab, shelfDesiredPosition + new Vector3(i, 0, 0), Quaternion.identity);
            shelfFlowers[i] = flower;
            shelfFlowers[i].SetActive(false);
        }
        for (int i = 0; i < stackCapacity; i++)
        {
            var flower = Instantiate(handFlowerPrefab, stackDesiredPosition + new Vector3(0, i, 0), Quaternion.identity);
            stackFlowers[i] = flower;
            stackFlowers[i].SetActive(false);
            stackFlowers[i].transform.parent = player.transform;
        }
    }
    public void AddStackFlower()
    {
        if (currentStackFlower < stackCapacity)
        {
            stackFlowers[currentStackFlower].SetActive(true);
            currentStackFlower++;
        }
    }
    public void AddProductFlower()
    {
        if (currentProductFlower < numberOfProductions)
        {
            productFlowers[currentProductFlower].SetActive(true);
            currentProductFlower++;
        }
    }
    public void AddShelfFlower()
    {
        if (currentShelfFlower < shelfCapacity)
        {
            shelfFlowers[currentShelfFlower].SetActive(true);
            currentShelfFlower++;
        }
    }

    public void RemoveStackFlower()
    {
        if (currentStackFlower >= 0)
        {
            stackFlowers[currentStackFlower].SetActive(false);
            currentStackFlower--;
        }
    }
    public void RemoveProductFlower()
    {
        if (currentProductFlower >= 0)
        {
            productFlowers[currentProductFlower].SetActive(false);
            currentProductFlower--;
        }
    }
    public void RemoveShelfFlower()
    {
        if (currentShelfFlower >= 0)
        {
            shelfFlowers[currentShelfFlower].SetActive(false);
            currentShelfFlower--;
        }
    }

}
