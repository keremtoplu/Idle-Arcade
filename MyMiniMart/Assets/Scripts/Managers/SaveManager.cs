using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : Singleton<SaveManager>
{

    void Start()
    {
        PlayerPrefs.SetInt("FlowerSheld", 0);
        PlayerPrefs.SetInt("FlowerProduct", 0);
        PlayerPrefs.SetInt("Checkout", 0);

    }

    public void LevelUp(string name)
    {
        switch (name)
        {
            case "FlowerSheld":
                var levelFlowerSheld = PlayerPrefs.GetInt("FlowerSheld");
                PlayerPrefs.SetInt("FlowerSheld", levelFlowerSheld++);
                break;

            case "FlowerProduct":
                var levelFlowerProduct = PlayerPrefs.GetInt("FlowerProduct");
                PlayerPrefs.SetInt("FlowerProduct", levelFlowerProduct++);
                break;

            case "Checkout":
                var levelCheckout = PlayerPrefs.GetInt("Checkout");
                PlayerPrefs.SetInt("Checkout", levelCheckout++);
                break;

        }
    }
}
