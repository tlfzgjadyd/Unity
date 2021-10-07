using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;//이거랑

public class okButtonEvent : MonoBehaviour, IPointerClickHandler//이거랑
{
    void Start()
    {
        Debug.Log("버튼 연동 완료");
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        { Debug.Log("입력창 옆의 확인버튼이 마우스 왼쪽버튼으로 눌렸다"); }
    }
}

//참고 : https://ssabi.tistory.com/43