using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearD : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // �� Ŭ��
        {
            SceneManager.LoadScene("Goyang_04_game");
        }
    }
}
