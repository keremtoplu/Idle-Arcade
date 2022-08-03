using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerSheld : MonoBehaviour, ICollectable
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
            SaveManager.Instance.LevelUp("FlowerSheld");
        }
    }
    public void Expand()
    {
        if (PlayerPrefs.GetInt("FlowerSheld") == 0)
        {
            timer = cost * .3f;
            //para animasyonu eklenecek
        }
        else
        {
            //çiçekler rafa koyulacak
        }

    }


}
