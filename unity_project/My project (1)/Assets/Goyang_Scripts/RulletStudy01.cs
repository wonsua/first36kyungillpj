using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RulletStudy01 : MonoBehaviour
{
    float rotSpeed = 0;  // ȸ�� �ӵ�   

    void Start()
    {
        // �����ӷ���Ʈ�� 60���� �����Ѵ�
        // �������� �������� �ٸ��� ������ �츮 ������ �ּ� ������ �������� ���;� �Ѵٸ� ����
        Application.targetFrameRate = 60; // ���� ��
    }

    void Update()
    {
        // Ŭ���ϸ� ȸ�� �ӵ��� �����Ѵ� , ���콺 Ŭ�� �ѹ��� ��� �Լ�
        // Input.anyKey Ű����� �ƹ�Ű�� �Է� �޾��� ��
        if (Input.GetMouseButtonDown(0)) // ���콺�� '������ ��' �ߵ� , Up�� ������ , �׳� ��ư�� ������ ����
        {
                rotSpeed = 10;
        }

        transform.Rotate(0, 0, rotSpeed); // this �� �����ص� �ȴ�


        if (rotSpeed < 0.1f)
        {
            rotSpeed = 0;
        }
        else
        {
                rotSpeed *= 0.994f;
                transform.Rotate(0, 0, rotSpeed); // this �� �����ص� �ȴ�
        }
        }
    }
        // ȸ�� �ӵ���ŭ �귿�� ȸ����Ų��        

