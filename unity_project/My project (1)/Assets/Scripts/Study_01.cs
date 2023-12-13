using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Study_01 : MonoBehaviour
{
    void Awake() //애가 스타트보다 빨리 1회 실행
    {
        Debug.LogError("Awake");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
    }

    void OnEnable() // 활성화 될 때 실행시키는 함수
    {
        Debug.Log("켜졌다");
    }
    void OnDisable() //비활성화 될 때 실행시키는 함수
    {
        Debug.Log("꺼졌다");
    }
    void OnDestroy() // 신 안에서 존재 자체가 사라질 때 나오는 함수
    {
        Debug.Log("으악! 범인은 나...?");
    }

    void OnApplicationPause(bool pause) // 게임이 정지 될 때 나오는 함수 데이터를 저장하는 함수를 넣음
    {

    }
    void OnApplicationQuit() // 게임이 꺼질 때 나오는 함수
    {
           
    }
    void OnApplicationFocus(bool focus) // 게임이 재가동 될 때 나오는 함수
    {
        
    }

    void Update()
    {

    }
}
