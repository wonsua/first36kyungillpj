using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float jumpForce = 380.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    Animator animator;

    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // 점프한다
        if (Input.GetKeyDown(KeyCode.Space) && rigid2D.velocity.y == 0)
        {
            rigid2D.AddForce(transform.up * jumpForce);
        }

        // 좌우 이동
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        // 플레이어 속도
        float speedx = Mathf.Abs(rigid2D.velocity.x); // Abs == 절대값 구하기 항상 양수가 나오도록

        // 스피드 제한
        if (speedx < maxWalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * walkForce);
        }
        // 움직이는 방향에 맞춰 이미지 반전
        if (key != 0)
        {
            SpriteRenderer sprite = GetComponent<SpriteRenderer>();
            //transform.localScale = new Vector3(key, 1, 1);
            if(key == -1)
            {
                sprite.flipX = true;
            }
            else
            {
                sprite.flipX = false;

            }
        }
        animator.speed = speedx / 2.0f;
    }
    void OnTriggerExit2D(Collider2D collision) // 이건 그냥 다 체크하는 것
    {
        Debug.Log("골");
        SceneManager.LoadScene("Goyang_04_clear"); // 같은걸 불러오면 재시작 가능
    }
}

