using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class integratedSecondButtonEvent : MonoBehaviour, IPointerClickHandler
{
    public GameObject integratedFirstInput;
    public GameObject integratedFirstButton;
    public GameObject integratedSecondOutput;
    public GameObject integratedSecondButton;

    void Start()
    {
        if (integratedSecondOutput != null)
            integratedSecondOutput.SetActive(false);
        if (integratedSecondButton != null)
            integratedSecondButton.SetActive(false);
    }

    // Update is called once per frame
    public void OnPointerClick(PointerEventData eventData)
    {
        toggle();
    }
    public void toggle()
    {
        if (integratedFirstInput != null)
            integratedFirstInput.SetActive(true);
        if (integratedFirstButton != null)
            integratedFirstButton.SetActive(true);

        integratedSecondOutput.SetActive(false);//이미 Start함수에서 null체크 되었기 때문에 체크 안해도됨, 의도에 맞게 다할수도 있고 이게 null인 상태로 절대로 돌아가선 안되는 경우에는 Start함수에서 검사 실패시 예외 던지거나 에러 로그 남기거나 해서 좀 더 강력한 조치를 취해줘야한다
        integratedSecondButton.SetActive(false);
    }
}
/*예를 들어 assert함수처럼 참, 거짓일거라 가정하고 실제론 검사 안하는 경우도 있잖아
 실제론 중단이 되겠지만 빌드 후에 그런 일은 일어나지 않을 것이라고 가정하는 경우들이 있음

 그래서 우리가 에러가 났을때 우리가 처리해야하는 오류로 다룰 것인지
아니면 의도된 예외 케이스로 다룰 것인지를 결정해야하며
그에 따라 다른 조치를 취해야한다*/