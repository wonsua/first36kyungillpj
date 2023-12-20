using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;
    void Update()
    {
        // 스와이프 길이를 구한다
        if (Input.GetMouseButtonDown(0))
        {
            // 마우스를 클릭한 좌표
            startPos = Input.mousePosition;
            //Debug.Log(startPos);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // 마우스 버튼에서 손가락을 떼었을 때 좌표
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;
            // 스와이프 길이를 처음 속도로 변환한다 500은 그냥 고정 값
            speed = swipeLength / 500.0f;
            // input.mousePosition으로 얻어지는 벡터값은 해상도의 영향을 받음
            //효과음 재생
            //gameObject.GetComponent<AudioSource>().Play();
        }
        transform.Translate(speed, 0, 0);  // 이동
        speed *= 0.98f;                    // 감속
    }
}
