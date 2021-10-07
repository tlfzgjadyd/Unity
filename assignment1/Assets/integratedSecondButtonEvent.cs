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

        integratedSecondOutput.SetActive(false);//�̹� Start�Լ����� nullüũ �Ǿ��� ������ üũ ���ص���, �ǵ��� �°� ���Ҽ��� �ְ� �̰� null�� ���·� ����� ���ư��� �ȵǴ� ��쿡�� Start�Լ����� �˻� ���н� ���� �����ų� ���� �α� ����ų� �ؼ� �� �� ������ ��ġ�� ��������Ѵ�
        integratedSecondButton.SetActive(false);
    }
}
/*���� ��� assert�Լ�ó�� ��, �����ϰŶ� �����ϰ� ������ �˻� ���ϴ� ��쵵 ���ݾ�
 ������ �ߴ��� �ǰ����� ���� �Ŀ� �׷� ���� �Ͼ�� ���� ���̶�� �����ϴ� ������ ����

 �׷��� �츮�� ������ ������ �츮�� ó���ؾ��ϴ� ������ �ٷ� ������
�ƴϸ� �ǵ��� ���� ���̽��� �ٷ� �������� �����ؾ��ϸ�
�׿� ���� �ٸ� ��ġ�� ���ؾ��Ѵ�*/