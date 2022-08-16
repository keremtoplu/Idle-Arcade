using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerProduct : MonoBehaviour, ICollectable
{

    [SerializeField]
    private int cost;



    private void Start()
    {
        if (PlayerPrefs.GetInt("FlowerProduct") == 0)
            transform.GetChild(1).gameObject.SetActive(false);
    }

    public void Expand()
    {
        if (PlayerPrefs.GetInt("FlowerProduct") == 0)
        {
            transform.GetChild(1).gameObject.SetActive(true);
            SaveManager.Instance.LevelUp("FlowerProduct");
            FlowerManager.Instance.CurrentProductCapacity++;
            FlowerManager.Instance.CurrentProductFlower++;
            FlowerManager.Instance.IsCollect = false;
            FlowerManager.Instance.ProduceFlower();
        }
        else
        {


        }
    }


}
