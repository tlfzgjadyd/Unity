using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;//�̰Ŷ�

public class secondButtonEvent : MonoBehaviour, IPointerClickHandler//�̰Ŷ�
{
    public GameObject firstInput;
    public GameObject firstButton;
    public GameObject secondOutput;
    public GameObject secondButton;

    public void OnPointerClick(PointerEventData eventData)//���⼭ PointerEventDataŸ���� eventData�� �־���� �ؿ��� ������ �����ϴ� �׸��� �̰� IPointerClickHadler�� ��ӹ޾ƾ� �� �� ���� �׸��� �ѿ� �� OnPointerclick �Լ��� ��������Ѵ�!!
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log("���� ����� ����ϴ� ��ư�� ���콺 ���ʹ�ư���� ���ȴ�");
            toggle();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if(secondOutput!=null) //gameObject�� �Լ��� ����ϴ� ��� �׻� null üũ�� ����������Ѵ�
            secondOutput.SetActive(false);
        if(secondButton!=null)//gameObject�� �Լ��� ����ϴ� ��� �׻� null üũ�� ����������Ѵ�
            secondButton.SetActive(false);
    }

    public void toggle()
    {
        if(firstInput!=null)
            firstInput.SetActive(true);
        if (firstButton != null)
            firstButton.SetActive(true);
        if (secondOutput != null)
            secondOutput.SetActive(false);
        if (secondButton != null)
            secondButton.SetActive(false);
        //this.SetActive(false); //�̷��� �ϸ� �ƿ� �۵��� ���Ѵ� �ֳ��ϸ� this�� ���� ��ư�� �ƴ϶� ��ư �̺�Ʈ�� �ش��ϱ� �����̴�
                                 //�׳� Event�� ��� ���� ���̵��� MonoBehaviour���� ��ӹ޴µ� MonoBehaviour�� game object�� ������ �ִ� SetActive ���� �Լ��� ����
        //gameObject.SetActive(true); //�̷��� �ϸ� �Ǳ�� �ϴµ� �ʹ� ���� ������ ����Ź��� 

        /*�ٵ� �⺻������ �ڱ��ڽ��� SetActive �������� ��� ���� �Լ��� ������ ������ ���� ���� �ֱ� ������ 
         ������ ���⺸�ٴ� �Ŵ����� �ϳ� �ּ� �����״� �ϴ� ���� ����*/

        /*���̵� ��ȸ ����� �� �Ƚ���Ѵ�
         id�̸��� ���� ���� ������ �幰����Ѵ�
         �̸��� �ٲ�⵵ ���� ����� �̸��� ���� �����̴�
        id �̸����� �˻��ϴ� ��� ��� ������Ʈ�� ������ ��ȸ�� ã�ƾ��ؼ� ����� �ſ� �����
        �׷��⶧���� ��ũ��Ʈ�� ���� ����� �����ؼ� ���� ����� ����
        
        find object�� �̷��� ������ ������ �ѵ� ����� �ʹ� ũ��
        �׷��� ������ ����Ǵ� update������ ����� �ἱ �ȵǸ�
        ��ư �������� �ѹ����� ã�°Ϳ��� ���� �ᵵ �Ǳ� ��
        ��� ���� ã�� ���� ��ư�� �߿����� ã�ƶ� �̷� ������� �����ؾ��Ѵ�
        �̰� ���� ã�ƺ���
         */
    }
}
