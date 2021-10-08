using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;//이거랑

public class firstButtonEvent : MonoBehaviour, IPointerClickHandler//이거랑
{
    public GameObject firstInput;
    public GameObject firstButton;//자기 자신이 firstButton인데도 this가 아니라 변수 선언해서 연결해서 하는 이상한 방식을 보여줌
    public GameObject secondOutput;
    public GameObject secondButton;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log("띄우고 숨기기 토글하는 버튼이 마우스 왼쪽버튼으로 눌렸다");
            toggle();
        }
    }

    public void toggle()
    {
        if(firstInput!=null)
            firstInput.SetActive(false);
        if(secondButton!=null)
            secondButton.SetActive(true);
        if(secondOutput!=null)
            secondOutput.SetActive(true);
        if(firstButton!=null)
            firstButton.SetActive(false);//자기 자신의 SetActive를 해제하면 밑의 함수들이 작동 안할 수도 있기 때문에 밑에다 둔다
    }
}
//play중에 작업하면 그건 휘발성임 사라진다
//그러므로 play모드 끄고 만들어야하고 play모드중에 작업해버려서 다 날라갔는데 지금 이 cs 파일만 남았지
//그렇다고 하더라도 이미 연결은 끊어진 상태이기 때문에 에디터에서 스크립트 새로 추가해서 내용 복붙으로 다시 만들어야한다

//그리고 input 하위구조에 placeholder랑 text 이런게 있는데
//button에도 마찬가지로 text가 있음 여기서 편집 가능



/*< 1. <게임오브젝트>.SetActive(false); <-오브젝트 작동 비활성화 & 화면 표시 금지

2. <게임오브젝트>.renderer.enabled = false; <- 오브젝트의 화면 표시 금지

참고: https://hyunity3d.tistory.com/381*/

//토글하기 위해 맨 처음에 hidden으로 시작해야하는 요소들이 있음
//그런 요소들은 해당 오브젝트에 스크립트를 연결해서 Start할때 처음부터 SetActive(false)로 지정해놓으면 되겠지!