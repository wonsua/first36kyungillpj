using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start() { }

    void Update()
    {
        // ���� ȭ��ǥ�� ������ ��
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (transform.position.x > -9) 
            { 
            transform.Translate(-3, 0, 0); // �������� ��3�� �����δ�
            }
        }

        // ������ ȭ��ǥ�� ������ ��
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (transform.position.x < 9)
            {
                transform.Translate(3, 0, 0); // ���������� ��3�� �����δ�
            }
            //time.deltatype�� ���ϴ� ������ 3��ŭ �����̴� ��
        }
    }

    public void LButtonDown()
    {
        if (transform.position.x > -9)
        {
        transform.Translate(-3,0,0);
        }
    }
    public void RButtonDown()
    {
        if (transform.position.x < 9)
        {
        transform.Translate(3,0,0);
        }

    }
}
