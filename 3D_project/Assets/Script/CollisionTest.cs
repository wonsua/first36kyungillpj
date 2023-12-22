using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // ���� ���콺�� ������ ��
        {

        } 
    }

    void OnMouseDown()
    {
        Debug.Log("��");
    }
   
    void OnMouseDrag()
    {
        Transform trans = GetComponent<Transform>();
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        trans.position = mousePos;
    }
}
