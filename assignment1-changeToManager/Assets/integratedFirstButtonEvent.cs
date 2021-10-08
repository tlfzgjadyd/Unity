using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class integratedFirstButtonEvent : MonoBehaviour, IPointerClickHandler
{
    public GameObject integratedFirstInput;
    public GameObject integratedFirstButton;
    public GameObject integratedSecondOutput;
    public GameObject integratedSecondButton;


    // Update is called once per frame
   public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log("띄우고 숨기기 토글하는 버튼이 마우스 왼쪽버튼으로 눌렸다");
            toggle();//아 왜 이상한가 했네 리스닝 함수를 안뒀었구나 toggle만 하면 무한반복으로 이상하게 작동하지
        }
         
    }
    
    public void toggle()
    {
        Debug.Log("integrated first button clicked");
        if(integratedFirstInput!=null)
            integratedFirstInput.SetActive(false);
        if(integratedSecondOutput!=null)
            integratedSecondOutput.SetActive(true);
        if(integratedSecondButton!=null)
            integratedSecondButton.SetActive(true);
        if (integratedFirstButton != null)
            integratedFirstButton.SetActive(false);
    }
}
