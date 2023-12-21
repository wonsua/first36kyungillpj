using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;
    GameObject player2;

    void Start()
    {
        player = GameObject.Find("player");
        player2 = GameObject.Find("PC2");
    }

    void Update()
    {
        // �����Ӹ��� ������� ���Ͻ�Ų�� 
        transform.Translate(0, -0.1f, 0);

        // ȭ�� ������ ������ ������Ʈ�� �Ҹ��Ų��
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        // �浹 ����
        Vector2 p1 = transform.position;         // ȭ���� �߽� ��ǥ
        Vector2 p2 = player.transform.position;  // �÷��̾��� �߽� ��ǥ
        Vector2 p3 = player2.transform.position;  // �÷��̾��� �߽� ��ǥ
        Vector2 dir = p1 - p2;
        Vector2 dir2 = p1 - p3;
        float d = dir.magnitude;
        float d2 = dir2.magnitude;
        float r1 = 0.5f;  // ȭ���� �ݰ� 
        float r2 = 1.0f;  // �÷��̾��� �ݰ�

        if (d <= r1 + r2)
        {
            // �浹�� ���� ȭ���� �����
            //GameObject director = GameObject.Find("GameD");
            //director.GetComponent<GameD>().DecreaseHp();
            //Destroy(gameObject);
        }
        if (d2 <= r1 + r2)
        {
            GameObject director = GameObject.Find("GameD");
            director.GetComponent<GameD>().DecreaseHp();
            Destroy(gameObject);

        }
    }
}
