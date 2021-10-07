using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;//�̰Ŷ�

public class firstButtonEvent : MonoBehaviour, IPointerClickHandler//�̰Ŷ�
{
    public GameObject firstInput;
    public GameObject firstButton;//�ڱ� �ڽ��� firstButton�ε��� this�� �ƴ϶� ���� �����ؼ� �����ؼ� �ϴ� �̻��� ����� ������
    public GameObject secondOutput;
    public GameObject secondButton;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log("���� ����� ����ϴ� ��ư�� ���콺 ���ʹ�ư���� ���ȴ�");
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
            firstButton.SetActive(false);//�ڱ� �ڽ��� SetActive�� �����ϸ� ���� �Լ����� �۵� ���� ���� �ֱ� ������ �ؿ��� �д�
    }
}
//play�߿� �۾��ϸ� �װ� �ֹ߼��� �������
//�׷��Ƿ� play��� ���� �������ϰ� play����߿� �۾��ع����� �� ���󰬴µ� ���� �� cs ���ϸ� ������
//�׷��ٰ� �ϴ��� �̹� ������ ������ �����̱� ������ �����Ϳ��� ��ũ��Ʈ ���� �߰��ؼ� ���� �������� �ٽ� �������Ѵ�

//�׸��� input ���������� placeholder�� text �̷��� �ִµ�
//button���� ���������� text�� ���� ���⼭ ���� ����



/*< 1. <���ӿ�����Ʈ>.SetActive(false); <-������Ʈ �۵� ��Ȱ��ȭ & ȭ�� ǥ�� ����

2. <���ӿ�����Ʈ>.renderer.enabled = false; <- ������Ʈ�� ȭ�� ǥ�� ����

����: https://hyunity3d.tistory.com/381*/

//����ϱ� ���� �� ó���� hidden���� �����ؾ��ϴ� ��ҵ��� ����
//�׷� ��ҵ��� �ش� ������Ʈ�� ��ũ��Ʈ�� �����ؼ� Start�Ҷ� ó������ SetActive(false)�� �����س����� �ǰ���!