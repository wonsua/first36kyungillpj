using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;
    void Update()
    {
        // �������� ���̸� ���Ѵ�
        if (Input.GetMouseButtonDown(0))
        {
            // ���콺�� Ŭ���� ��ǥ
            startPos = Input.mousePosition;
            //Debug.Log(startPos);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // ���콺 ��ư���� �հ����� ������ �� ��ǥ
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;
            // �������� ���̸� ó�� �ӵ��� ��ȯ�Ѵ� 500�� �׳� ���� ��
            speed = swipeLength / 500.0f;
            // input.mousePosition���� ������� ���Ͱ��� �ػ��� ������ ����
            //ȿ���� ���
            //gameObject.GetComponent<AudioSource>().Play();
        }
        transform.Translate(speed, 0, 0);  // �̵�
        speed *= 0.98f;                    // ����
    }
}
