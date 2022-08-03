using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerProduct : MonoBehaviour, ICollectable
{

    [SerializeField]
    private int cost;
    float timer;
    private void Start()
    {
        if (PlayerPrefs.GetInt("FlowerProduct") == 0)
            transform.GetChild(1).gameObject.SetActive(false);
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer == 0)
        {
            transform.GetChild(1).gameObject.SetActive(true);
            SaveManager.Instance.LevelUp("FlowerProduct");
        }
    }
    public void Expand()
    {
        if (PlayerPrefs.GetInt("FlowerProduct") == 0)
        {
            timer = cost * 0.3f;
        }
        else
        {
            //üretilen çiçekler verilecek
        }
    }


}
