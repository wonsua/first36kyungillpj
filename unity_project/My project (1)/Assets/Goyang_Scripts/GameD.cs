using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameD : MonoBehaviour
{
    GameObject HpGauge;
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        HpGauge = GameObject.Find("HP");
    }

    public void DecreaseHp()
    {
        HpGauge.GetComponent<Image>().fillAmount -= 0.4f;
        if (HpGauge.GetComponent<Image>().fillAmount <= 0 ) 
        {
            gameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ReStart()
    {
        HpGauge.GetComponent<Image>().fillAmount = 1f;
        gameOver.SetActive(false);
        Time.timeScale = 1;
    }
}
