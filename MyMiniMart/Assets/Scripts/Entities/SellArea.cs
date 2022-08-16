using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellArea : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        for (int i = 0; i < PlayerController.Instance.Stack.ItemCount; i++)
        {
            PlayerController.Instance.Stack.RemoveStack();
            //leantween
            CoinManager.Instance.AddMoney(FlowerManager.Instance.FlowerPrize);
        }
    }
}
