using System.Collections;
using System.Collections.Generic;
using TMPro; // 필수
using UnityEngine; // 필수
using UnityEngine.UI; // 필수

public class BattleStudy_01 : MonoBehaviour
{
    public Sprite[] monsterimg; // 적 이미지 모음
    public Image llama; // 라마 이미지 (PC)
    public float llamaHp = 100; // 라마 초기 체력
    public float monHp = 100; // 알파 초기 체력
    public GameObject mon_bg; // 적 몬스터 이미지
    public GameObject run; // 게임 종료
    public TextMeshProUGUI llamaHpT; // 라마 체력 텍스트
    public TextMeshProUGUI monHpT; // 알파 체력 텍스트
    public TextMeshProUGUI turn; // 턴 정보 텍스트

    float damage; // 랜덤 데미지 값 선언
    bool Atkbtn; //공격 버튼 클릭
    //[SerializeField]
    public TextMeshProUGUI damage_text; // 랜덤 데미지 담는 값
    public Slider llama_Hp; // 라마 현재 체력
    public Slider mon_Hp; // 적 현재 체력

    public Image mon; // 알파 이미지 (적)

    public float llamaHpF; // 라마 초기 체력 저장값
    public float monHpF; // 적 초기 체력 저장 값
    void Start()
    {
        llamaHpF = llamaHp; // 라마의 초기 체력을 라마의 최대 체력으로 저장해 주는 변수
        monHpF = monHp; // 적의 초기 체력을 적의 최대 체력으로 저장해주는 변수
        llama_Hp.maxValue = llamaHpF; // 라마의 현재 체력 게이지를 보여주는 변수
        mon_Hp.maxValue = monHpF; // 몬스터의 현재 체력 게이지를 보여주는 변수
        mon.sprite = monsterimg[Random.Range(0, 4)]; // 몬스터 이미지를 랜덤으로 적용해줌 5개의 이미지를 직접 넣어야함 빈공간이 있으면 안됨
    }

    private void Update() // 매 프레임 단위로 업데이트 해주는 함수
    {
        llama_Hp.value = llamaHp; // 현재 라마 체력의 게이지를 변환해줌
        mon_Hp.value = monHp; // 현재 적의 체력 게이지를 변환해줌
    }

    public void BattleTurn() // 공격 버튼을 눌렀을 때 직접 작용하는 함수
    {

        if (!mon_bg.activeSelf) // 적 이미지가 없을 때 공격 버튼을 누를 경우
        {
            mon.sprite = monsterimg[Random.Range(0, 4)]; // 적 이미지를 랜덤으로 넣음
            mon_bg.SetActive(true); // 적 이미지를 다시 생성함
        }

        else // 적 이미지가 있을 때 공격 버튼을 누를 경우
        {
            if (Atkbtn) // 버튼을 눌렀을 때 온오프 해주는 기능 초기값은 따로 선언이 없을 시에 true
            {
                int damage = Random.Range(10, 20); // 랜덤 데미지 값 함수 10~20
                monHp -= damage; // 알파 체력 빼는거
                if (monHp < 0) // 적 몬스터 체력이 0 이하가 되었을 때
                {
                    damage_text.color = Color.black; // 피해 현황 색을 검은색으로 바꿈
                    damage_text.text = damage.ToString() + " 의 피해를 입혀 쓰러 트렸다."; // 랜덤 데미지의 피해를 얼마나 입었는지 텍스트로 보여줌
                    mon_bg.SetActive(false); // 적을 처치했으니 적의 게임 오브젝트를 꺼서 이미지를 없앰
                    monHp = monHpF; // 적의 체력을 풀로 채움
                    mon_Hp.maxValue = monHpF; // 적의 체력 게이지를 풀로 채움

                }
                else // 적 몬스터 체력이 1 이상 남아 있을 때
                {
                    damage_text.color = Color.black; // 피해 현황 색을 검은색으로 바꿈
                    damage_text.text = damage.ToString() + " 의 피해를 입혔다."; // 랜덤 데미지의 피해를 얼마나 입었는지 텍스트로 보여줌

                    Atkbtn = false; // if 문 스위치를 false 로 바꾼다
                }
                monHpT.text = monHp + "/" + monHpF; // 적 체력을 슬라이더에 정수형으로 체력을 보여줌
                llamaHpT.text = llamaHp + "/" + llamaHpF; // 라마 체력을 슬라이더에 정수형으로 체력을 보여줌
                turn.color = Color.red; // 턴 상황 텍스트를 붉은색으로 바꿈
                turn.text = "적 턴"; // 턴 상황 텍스트를 적 턴으로 바꿈
            }
            else
            {
                int damage = Random.Range(10, 20); // 랜덤 데미지 값 함수 10~20
                llamaHp -= damage; // 라마 체력 빼는거
                if (llamaHp < llamaHpF / 2) // 라마 최대체력이 반피 이하일 때
                {
                    llamaHp += llamaHpF / 4; // 라마 최대체력의 25%를 회복 시켜준다
                    damage_text.color = Color.red; // 테스트를 붉은색으로 바꾼다
                    damage_text.text = damage.ToString() + " 의 피해를 입고 반피 이하가 되어서 피를 25% 회복했다."; // 데미지를 받고 회복했다는 것을 출력해줌
                }
                else // 라마 최대 체력이 반피 이상일 때
                {
                    damage_text.color = Color.red; // 텍스트를 붉은색으로 바꾼다
                    damage_text.text = damage.ToString() + " 의 피해를 입었다."; // 랜덤 데미지를 문자열로 바꿔서 출력해주는 것
                }
                monHpT.text = monHp + "/" + monHpF; // 적 체력을 슬라이더에 정수형으로 체력을 보여줌
                llamaHpT.text = llamaHp + "/" + llamaHpF; // 라마 체력을 슬라이더에 정수형으로 체력을 보여줌
                turn.color = Color.black; // 턴 상황 텍스트 색을 검은색으로 바꿔줌
                turn.text = "내 턴"; // 턴 상황 텍스트를 내 턴으로 바꿈
                Atkbtn = true; // if 문 스위치를 true 로 바꾼다

            }
        }
    }
}