using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GD : MonoBehaviour
{
    public GameObject car;     // "car" 라는 " GameObject"를 담은 변수
    public GameObject flag;
    public GameObject distance;

    void Start()
    {
        //GameObject.Fine("하이어라키에 "켜져있는" 오브젝트들 중 이름으로 찾는 방법)
        car = GameObject.Find("KakaoTalk_20231212_232847938.png-removebg-preview");
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance");
        flagPosX = flag.transform.position.x;
    }
    float flagPosX;
    void Update()
    {
        // Start(0에서 flag, car를 찾았음
        // gameObject.transform.position =
        // 그 오브젝트의 위치 정보(좌표값)을 받아옴
        float length = flagPosX - car.transform.position.x;
        distance.GetComponent<TextMeshProUGUI>().text = "Distance:" + length.ToString("F2") + "m"; // 소수점 둘번째 자리까지만 보여준다
    }
}

