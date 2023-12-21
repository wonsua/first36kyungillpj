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
        // �����Ѵ�
        if (Input.GetKeyDown(KeyCode.Space) && rigid2D.velocity.y == 0)
        {
            rigid2D.AddForce(transform.up * jumpForce);
        }

        // �¿� �̵�
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        // �÷��̾� �ӵ�
        float speedx = Mathf.Abs(rigid2D.velocity.x); // Abs == ���밪 ���ϱ� �׻� ����� ��������

        // ���ǵ� ����
        if (speedx < maxWalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * walkForce);
        }
        // �����̴� ���⿡ ���� �̹��� ����
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
    void OnTriggerExit2D(Collider2D collision) // �̰� �׳� �� üũ�ϴ� ��
    {
        Debug.Log("��");
        SceneManager.LoadScene("Goyang_04_clear"); // ������ �ҷ����� ����� ����
    }
}

