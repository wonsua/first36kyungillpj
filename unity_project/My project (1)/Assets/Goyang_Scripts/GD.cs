using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GD : MonoBehaviour
{
    public GameObject car;     // "car" ��� " GameObject"�� ���� ����
    public GameObject flag;
    public GameObject distance;

    void Start()
    {
        //GameObject.Fine("���̾��Ű�� "�����ִ�" ������Ʈ�� �� �̸����� ã�� ���)
        car = GameObject.Find("KakaoTalk_20231212_232847938.png-removebg-preview");
        flag = GameObject.Find("flag");
        distance = GameObject.Find("Distance");
        flagPosX = flag.transform.position.x;
    }
    float flagPosX;
    void Update()
    {
        // Start(0���� flag, car�� ã����
        // gameObject.transform.position =
        // �� ������Ʈ�� ��ġ ����(��ǥ��)�� �޾ƿ�
        float length = flagPosX - car.transform.position.x;
        distance.GetComponent<TextMeshProUGUI>().text = "Distance:" + length.ToString("F2") + "m"; // �Ҽ��� �ѹ�° �ڸ������� �����ش�
    }
}

