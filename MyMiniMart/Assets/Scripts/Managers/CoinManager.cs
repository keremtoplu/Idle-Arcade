using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : Singleton<CoinManager>
{
    [SerializeField]
    private int startMoney;



    private int currentMoney;

    public int StartMoney => startMoney;
    public int CurrentMoney => currentMoney;
    private void Start()
    {
        currentMoney = startMoney;
    }

    public void AddMoney(int addedMoney)
    {
        currentMoney += addedMoney;
        PlayerPrefs.SetInt("CurrentMoney", currentMoney);
    }

    public void SubMoney(int subbedMoney)
    {
        currentMoney -= subbedMoney;
        PlayerPrefs.SetInt("CurrentMoney", currentMoney);
    }

}
