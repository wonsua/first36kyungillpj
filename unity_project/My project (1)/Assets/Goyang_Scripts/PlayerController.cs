using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start() { }

    void Update()
    {
        // 왼쪽 화살표가 눌렸을 때
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (transform.position.x > -9) 
            { 
            transform.Translate(-3, 0, 0); // 왼쪽으로 「3」 움직인다
            }
        }

        // 오른쪽 화살표가 눌렸을 때
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (transform.position.x < 9)
            {
                transform.Translate(3, 0, 0); // 오른쪽으로 「3」 움직인다
            }
            //time.deltatype을 곱하는 이유는 3만큼 움직이는 것
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
