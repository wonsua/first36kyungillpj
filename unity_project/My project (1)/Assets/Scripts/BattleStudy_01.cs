using System.Collections;
using System.Collections.Generic;
using TMPro; // �ʼ�
using UnityEngine; // �ʼ�
using UnityEngine.UI; // �ʼ�

public class BattleStudy_01 : MonoBehaviour
{
    public Sprite[] monsterimg; // �� �̹��� ����
    public Image llama; // �� �̹��� (PC)
    public float llamaHp = 100; // �� �ʱ� ü��
    public float monHp = 100; // ���� �ʱ� ü��
    public GameObject mon_bg; // �� ���� �̹���
    public GameObject run; // ���� ����
    public TextMeshProUGUI llamaHpT; // �� ü�� �ؽ�Ʈ
    public TextMeshProUGUI monHpT; // ���� ü�� �ؽ�Ʈ
    public TextMeshProUGUI turn; // �� ���� �ؽ�Ʈ

    float damage; // ���� ������ �� ����
    bool Atkbtn; //���� ��ư Ŭ��
    //[SerializeField]
    public TextMeshProUGUI damage_text; // ���� ������ ��� ��
    public Slider llama_Hp; // �� ���� ü��
    public Slider mon_Hp; // �� ���� ü��

    public Image mon; // ���� �̹��� (��)

    public float llamaHpF; // �� �ʱ� ü�� ���尪
    public float monHpF; // �� �ʱ� ü�� ���� ��
    void Start()
    {
        llamaHpF = llamaHp; // ���� �ʱ� ü���� ���� �ִ� ü������ ������ �ִ� ����
        monHpF = monHp; // ���� �ʱ� ü���� ���� �ִ� ü������ �������ִ� ����
        llama_Hp.maxValue = llamaHpF; // ���� ���� ü�� �������� �����ִ� ����
        mon_Hp.maxValue = monHpF; // ������ ���� ü�� �������� �����ִ� ����
        mon.sprite = monsterimg[Random.Range(0, 4)]; // ���� �̹����� �������� �������� 5���� �̹����� ���� �־���� ������� ������ �ȵ�
    }

    private void Update() // �� ������ ������ ������Ʈ ���ִ� �Լ�
    {
        llama_Hp.value = llamaHp; // ���� �� ü���� �������� ��ȯ����
        mon_Hp.value = monHp; // ���� ���� ü�� �������� ��ȯ����
    }

    public void BattleTurn() // ���� ��ư�� ������ �� ���� �ۿ��ϴ� �Լ�
    {

        if (!mon_bg.activeSelf) // �� �̹����� ���� �� ���� ��ư�� ���� ���
        {
            mon.sprite = monsterimg[Random.Range(0, 4)]; // �� �̹����� �������� ����
            mon_bg.SetActive(true); // �� �̹����� �ٽ� ������
        }

        else // �� �̹����� ���� �� ���� ��ư�� ���� ���
        {
            if (Atkbtn) // ��ư�� ������ �� �¿��� ���ִ� ��� �ʱⰪ�� ���� ������ ���� �ÿ� true
            {
                int damage = Random.Range(10, 20); // ���� ������ �� �Լ� 10~20
                monHp -= damage; // ���� ü�� ���°�
                if (monHp < 0) // �� ���� ü���� 0 ���ϰ� �Ǿ��� ��
                {
                    damage_text.color = Color.black; // ���� ��Ȳ ���� ���������� �ٲ�
                    damage_text.text = damage.ToString() + " �� ���ظ� ���� ���� Ʈ�ȴ�."; // ���� �������� ���ظ� �󸶳� �Ծ����� �ؽ�Ʈ�� ������
                    mon_bg.SetActive(false); // ���� óġ������ ���� ���� ������Ʈ�� ���� �̹����� ����
                    monHp = monHpF; // ���� ü���� Ǯ�� ä��
                    mon_Hp.maxValue = monHpF; // ���� ü�� �������� Ǯ�� ä��

                }
                else // �� ���� ü���� 1 �̻� ���� ���� ��
                {
                    damage_text.color = Color.black; // ���� ��Ȳ ���� ���������� �ٲ�
                    damage_text.text = damage.ToString() + " �� ���ظ� ������."; // ���� �������� ���ظ� �󸶳� �Ծ����� �ؽ�Ʈ�� ������

                    Atkbtn = false; // if �� ����ġ�� false �� �ٲ۴�
                }
                monHpT.text = monHp + "/" + monHpF; // �� ü���� �����̴��� ���������� ü���� ������
                llamaHpT.text = llamaHp + "/" + llamaHpF; // �� ü���� �����̴��� ���������� ü���� ������
                turn.color = Color.red; // �� ��Ȳ �ؽ�Ʈ�� ���������� �ٲ�
                turn.text = "�� ��"; // �� ��Ȳ �ؽ�Ʈ�� �� ������ �ٲ�
            }
            else
            {
                int damage = Random.Range(10, 20); // ���� ������ �� �Լ� 10~20
                llamaHp -= damage; // �� ü�� ���°�
                if (llamaHp < llamaHpF / 2) // �� �ִ�ü���� ���� ������ ��
                {
                    llamaHp += llamaHpF / 4; // �� �ִ�ü���� 25%�� ȸ�� �����ش�
                    damage_text.color = Color.red; // �׽�Ʈ�� ���������� �ٲ۴�
                    damage_text.text = damage.ToString() + " �� ���ظ� �԰� ���� ���ϰ� �Ǿ �Ǹ� 25% ȸ���ߴ�."; // �������� �ް� ȸ���ߴٴ� ���� �������
                }
                else // �� �ִ� ü���� ���� �̻��� ��
                {
                    damage_text.color = Color.red; // �ؽ�Ʈ�� ���������� �ٲ۴�
                    damage_text.text = damage.ToString() + " �� ���ظ� �Ծ���."; // ���� �������� ���ڿ��� �ٲ㼭 ������ִ� ��
                }
                monHpT.text = monHp + "/" + monHpF; // �� ü���� �����̴��� ���������� ü���� ������
                llamaHpT.text = llamaHp + "/" + llamaHpF; // �� ü���� �����̴��� ���������� ü���� ������
                turn.color = Color.black; // �� ��Ȳ �ؽ�Ʈ ���� ���������� �ٲ���
                turn.text = "�� ��"; // �� ��Ȳ �ؽ�Ʈ�� �� ������ �ٲ�
                Atkbtn = true; // if �� ����ġ�� true �� �ٲ۴�

            }
        }
    }
}