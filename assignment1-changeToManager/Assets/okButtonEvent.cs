using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;//�̰Ŷ�

public class okButtonEvent : MonoBehaviour, IPointerClickHandler//�̰Ŷ�
{
    void Start()
    {
        Debug.Log("��ư ���� �Ϸ�");
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        { Debug.Log("�Է�â ���� Ȯ�ι�ư�� ���콺 ���ʹ�ư���� ���ȴ�"); }
    }
}

//���� : https://ssabi.tistory.com/43