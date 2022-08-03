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
    private void Update()
    {

    }
    public void Expand()
    {
        if (PlayerPrefs.GetInt("FlowerProduct") == 0)
        {
            transform.GetChild(1).gameObject.SetActive(true);
            SaveManager.Instance.LevelUp("FlowerProduct");
        }
        else
        {
            for (int i = 0; i <= FlowerManager.Instance.CurrentProductFlower; i++)
            {
                FlowerManager.Instance.RemoveProductFlower();
                FlowerManager.Instance.AddStackFlower();
            }
            //üretilen çiçekler verilecek
        }
    }


}
