using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Study_01 : MonoBehaviour
{
    void Awake() //�ְ� ��ŸƮ���� ���� 1ȸ ����
    {
        Debug.LogError("Awake");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
    }

    void OnEnable() // Ȱ��ȭ �� �� �����Ű�� �Լ�
    {
        Debug.Log("������");
    }
    void OnDisable() //��Ȱ��ȭ �� �� �����Ű�� �Լ�
    {
        Debug.Log("������");
    }
    void OnDestroy() // �� �ȿ��� ���� ��ü�� ����� �� ������ �Լ�
    {
        Debug.Log("����! ������ ��...?");
    }

    void OnApplicationPause(bool pause) // ������ ���� �� �� ������ �Լ� �����͸� �����ϴ� �Լ��� ����
    {

    }
    void OnApplicationQuit() // ������ ���� �� ������ �Լ�
    {
           
    }
    void OnApplicationFocus(bool focus) // ������ �簡�� �� �� ������ �Լ�
    {
        
    }

    void Update()
    {

    }
}
