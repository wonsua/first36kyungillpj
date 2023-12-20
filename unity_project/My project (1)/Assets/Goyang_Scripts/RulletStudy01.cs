using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RulletStudy01 : MonoBehaviour
{
    float rotSpeed = 0;  // 회전 속도   

    void Start()
    {
        // 프레임레이트를 60으로 고정한다
        // 기종마다 프레임이 다르기 때문에 우리 게임은 최소 이정도 프레임은 나와야 한다를 설정
        Application.targetFrameRate = 60; // 몰라도 됨
    }

    void Update()
    {
        // 클릭하면 회전 속도를 설정한다 , 마우스 클릭 한번을 잡는 함수
        // Input.anyKey 키보드로 아무키나 입력 받았을 때
        if (Input.GetMouseButtonDown(0)) // 마우스를 '눌렀을 때' 발동 , Up은 땟을때 , 그냥 버튼은 누르는 동안
        {
                rotSpeed = 10;
        }

        transform.Rotate(0, 0, rotSpeed); // this 는 무시해도 된다


        if (rotSpeed < 0.1f)
        {
            rotSpeed = 0;
        }
        else
        {
                rotSpeed *= 0.994f;
                transform.Rotate(0, 0, rotSpeed); // this 는 무시해도 된다
        }
        }
    }
        // 회전 속도만큼 룰렛을 회전시킨다        

