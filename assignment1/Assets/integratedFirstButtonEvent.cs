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
            Debug.Log("���� ����� ����ϴ� ��ư�� ���콺 ���ʹ�ư���� ���ȴ�");
            toggle();//�� �� �̻��Ѱ� �߳� ������ �Լ��� �ȵ׾����� toggle�� �ϸ� ���ѹݺ����� �̻��ϰ� �۵�����
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
