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
    private void Update()
    {
        // timer -= Time.deltaTime;
        // if (timer == 0)
        // {
        //     transform.GetChild(1).gameObject.SetActive(true);
        //     SaveManager.Instance.LevelUp("FlowerSheld");
        //     Debug.Log(timer);
        // }
    }
    public void Expand()
    {
        if (cost < CoinManager.Instance.CurrentMoney)
        {
            if (PlayerPrefs.GetInt("FlowerSheld") == 0)
            {
                transform.GetChild(1).gameObject.SetActive(true);
                SaveManager.Instance.LevelUp("FlowerSheld");
                CoinManager.Instance.SubMoney(cost);
            }
            else
            {
                FlowerManager.Instance.AddShelfFlower();
                SaveManager.Instance.LevelUp("FlowerSheld");
                CoinManager.Instance.SubMoney(cost);
            }
        }

    }


}
