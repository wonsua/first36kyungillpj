using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManger : MonoBehaviour
{

    public Image bg;
    bool isChanged;

    Sprite WallPapper01; // 원래 것
    [SerializeField]
    Sprite WallPapper02; // 변경 시킬 것

    [SerializeField]
    TextMeshProUGUI _text;

    int descid = 0;


    void Start()
    {
        WallPapper01 = bg.sprite;
    }
    public void ChangeColor()
    {
        if (isChanged)
        {
            bg.sprite = WallPapper01;
            _text.text ="emma is god";
            isChanged = false;
        }
        else
        {
            bg.sprite = WallPapper02;
            _text.text ="sua get to daze www~~";
            isChanged = true;
        }
    }


}
