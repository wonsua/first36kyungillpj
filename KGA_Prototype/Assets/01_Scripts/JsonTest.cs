using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1. ������(�ڵ� = Ŭ����)�� ������ ��. -> ������ ������ ����
// 2. �� �����͸� Json���� ��ȯ. (�ù���ڷ� ����)
// 3. Json(�ù�)�� �ٽ� ������ �ڵ�� �ٲٴ� ���
// ���̽�(�ù�) -> ������ -> Ŭ����(�ڵ�)

class Data
{
    public string nickname;
    public int level;
    public int coin;
    public bool skill;
    // ��Ÿ ���...
    // ���⼭ �ٷ� �⺻ ���� ���� ���� ���� ����, ������ �����͸��� �⺻ ���� �ٸ� �� �־� ���⼭ �ϸ� �ȵ�
}


public class JsonTest : MonoBehaviour
{
    Data player = new Data() { nickname = "��", level = 50, coin = 200, skill = false }; // DataŬ������ ������ ���� player��� ������ ����

    // Start is called before the first frame update
    void Start()
    {
        // 2. Json���� ��ȯ
        string jsonData = JsonUtility.ToJson(player);

        Data player2 = JsonUtility.FromJson<Data>(jsonData);
        print(player2.nickname);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
