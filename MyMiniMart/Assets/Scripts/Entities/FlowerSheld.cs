using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerSheld : MonoBehaviour, ICollectable
{
    [SerializeField]
    private int cost;

    [SerializeField]
    private StackController shelfStack;

    public StackController ShelfStack => shelfStack;
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
            for (int i = 0; i < shelfStack.StackCapacity; i++)
            {
                if (PlayerController.Instance.Stack.ItemCount > 0)
                    shelfStack.AddStack(PlayerController.Instance.Stack.RemoveStack());
            }
        }


    }


}
