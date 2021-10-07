using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //이거 필요함

public class inputEvent : MonoBehaviour
{
    public InputField m_InputField;//아 이 input이벤트 처리할때는 gameobject가 아니라 inputfield랑 button으로 처리해야했구나
    public Button m_Button;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("연동완료");
        m_Button.onClick.AddListener(() => //확인버튼이 눌리는 것을 감지하기 위해 리스너를 달았다
        {
            if (m_InputField.text != null)
                Debug.Log(m_InputField.text);
        });
    }

    // Update is called once per frame
    void Update()
    {

    }
}
//일단 inspector에서 스크립트에 input Field 아이템 채워주니까 에러는 안나는데
//input UI의 경우 2가지 설정이 있음
/* 
 * On Value Changed는 변화 일어날 때 마다 실행되는거고
 * On End Edit은 입력 끝나면 한번 실행됨
 */

//코드에 ;빠지거나 해서 에러 조금이라도 있으면 inspector창에 안뜨는 것들이 생긴다
//이번에 버튼 변수 안뜬 이유도 이것때문임

//작동방식이 1. UI본체 생성
//2. 스크립트 만들고 본체에 연결
//3. 스크립트 내에 변수를 만들고 코드에 문제가 없는 경우 본체의 inspector창에 그 변수를 실체에 연결해달라고 뜨게됨 그거 드래그하거나 옆에 버튼 눌러서 연결해줌

//4. 여기에 추가로 input창, 확인창의 경우 input의 스크립트쪽에서 버튼 리스너로 버튼 클릭되는걸 듣고있다가 텍스트를 출력하거나 뭔가를 해줘야됨