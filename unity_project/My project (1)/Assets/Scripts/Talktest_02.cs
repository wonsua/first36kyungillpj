using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Talktest_02 : MonoBehaviour
{
    int desNum = 0;
    public Image chrbg;
    public GameObject llama;
    public GameObject alpaca;
    public GameObject dryerd;
    public GameObject Textbg;
    public GameObject Textbtn;
    public GameObject startbtn;
 
    [SerializeField]
    Sprite bg_talk_llama; // 라마
    [SerializeField]
    Sprite bg_talk_alpaca; // 알파카
    [SerializeField]
    Sprite bg_talk_dryerd; // 드라어드

    [SerializeField]
    TextMeshProUGUI chr_text;

    string[] array_01 = {"1","2","3","4","5"};

    public Image[] array_02 = new Image[5];
    
    void Start()
    {
        bg_talk_llama = chrbg.sprite;
    }
    public void Changeimg()
    {
        if (desNum == 0)
        {
            Textbg.SetActive(true);
            Textbtn.SetActive(true);
            startbtn.SetActive(false);
            llama.SetActive(true);
            alpaca.SetActive(true);
            dryerd.SetActive(true);

        }
        else if (desNum == 5)
        {
            {
                startbtn.SetActive(true);
                Textbtn.SetActive(false);
                Textbg.SetActive(false);
            llama.SetActive(false);
            alpaca.SetActive(false);
            dryerd.SetActive(false);
            }
        }
        if (desNum == 5)
        {
            desNum = 0;
        }
        else
        {   
            chr_text.text = array_01[desNum];
            desNum++;
        }

    }
}

