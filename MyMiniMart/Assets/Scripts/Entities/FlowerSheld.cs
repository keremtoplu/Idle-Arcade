using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerSheld : MonoBehaviour, ICollectable
{
    [SerializeField]
    private int cost;
    // float timer;
    private void Start()
    {
        if (PlayerPrefs.GetInt("FlowerSheld") == 0)
            transform.GetChild(1).gameObject.SetActive(false);
    }

    public void Expand()
    {
        if (PlayerPrefs.GetInt("FlowerSheld") == 0)
        {
            if (cost < CoinManager.Instance.CurrentMoney)
            {
                transform.GetChild(1).gameObject.SetActive(true);
                SaveManager.Instance.LevelUp("FlowerSheld");
                CoinManager.Instance.SubMoney(cost);
            }

        }
        else
        {

        }


    }


}
