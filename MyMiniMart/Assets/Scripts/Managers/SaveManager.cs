using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : Singleton<SaveManager>
{

    private void Start()
    {
        PlayerPrefs.SetInt("CurrentMoney", CoinManager.Instance.StartMoney);
    }
    public void LevelUp(string name)
    {
        switch (name)
        {
            case "FlowerSheld":
                PlayerPrefs.SetInt("FlowerSheld", PlayerPrefs.GetInt("FlowerSheld") + 1);
                break;

            case "FlowerProduct":
                PlayerPrefs.SetInt("FlowerProduct", PlayerPrefs.GetInt("FlowerProduct") + 1);
                break;

            case "Checkout":
                PlayerPrefs.SetInt("Checkout", PlayerPrefs.GetInt("Checkout"));
                break;

        }
    }
}
