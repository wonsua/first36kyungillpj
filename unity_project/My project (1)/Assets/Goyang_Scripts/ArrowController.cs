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
        // 프레임마다 등속으로 낙하시킨다 
        transform.Translate(0, -0.1f, 0);

        // 화면 밖으로 나오면 오브젝트를 소멸시킨다
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        // 충돌 판정
        Vector2 p1 = transform.position;         // 화살의 중심 좌표
        Vector2 p2 = player.transform.position;  // 플레이어의 중심 좌표
        Vector2 p3 = player2.transform.position;  // 플레이어의 중심 좌표
        Vector2 dir = p1 - p2;
        Vector2 dir2 = p1 - p3;
        float d = dir.magnitude;
        float d2 = dir2.magnitude;
        float r1 = 0.5f;  // 화살의 반경 
        float r2 = 1.0f;  // 플레이어의 반경

        if (d <= r1 + r2)
        {
            // 충돌한 경우는 화살을 지운다
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
