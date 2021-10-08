using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singletonPractice : MonoBehaviour
{
    //������Ʈ���� �ڱ� �ڽ��� SetActive(false)�ϴ°� ���ۿ� �̻���
    //���� ���� �ְ� ������ �̻��ϹǷ� �ܺ��� �Ŵ������� �̸� ��� �������ֵ��� �Ѵ�
    //������ �̱������� �����ϴ°͸� �ѰŰ�
    //������ ������ �ٸ� ������Ʈ���� ������ ������ �־�� �Ѵ�
    private static singletonPractice instance; // �̱����� �Ҵ��� ������µ� �̻���� public���� �س�����
                                                //���� ���ɷε� �׷��� �ٸ���� �ڵ嵵 �׷��� private�� �´�
                                                 //�ȱ׷� �ܺο��� ���� ���������� �̱����� ����� �ȵ��ݾ�
    //�̶� �߿��Ѱ� �ش� ������ Ÿ���� ���� �ۼ��ϰ� �ִ� �� Ŭ������ ��ġ�ؾ��Ѵٴ� ���̴�
    //�̰� ��ü�� ����ְ� ��� �ϴ� ������Ʈ�� �׷���

    //���� ���۰� ���ÿ� �̱��� ����
    void Awake()
    {
        if(instance ==null)
        {
            instance = this;//�� ���� ���ο�� ������ ���Ѱǰ�
            //c++���۷��� Ŭ���� �ȿ��� Ŭ������ �ν��Ͻ��� ������ ��Ī�Ҷ�
            //this�ϰ� operator()���Ǿȵ��־ �ȵ� �Ϲ������� 
            //instance = this(); �̰Ŵ� �������µ�
            //instance = new singletonPractice();//�Ϲ� c#�̸� �̷����ؾ��ϴµ� ������ ����Ƽ �ȿ� �ִµ�
            //���behaviour��ӹ޾Ұ� awake�� �������ϱ� �̹� �ν��Ͻ��� �������� 
            //�׷��� �̹� �����ֱ⿡ this�� �Ҵ���ֱ� ������ �� ������x
            //���� ��ӹ��� �ֵ� �� �׷��� �Ϲ����� ������� ��ӹ޾Ұų� ���� ������Ʈ ��ӹ��� �ֵ���
            //�� instantiate�� �����

            //�̱����� �� �����ϰ� ������ ���� ��� ������ ȯ�� ���� ���������� ����
            //�̱��� ���� ���� ������ �츮�� �ȿ��� ���������� �̱��� �ϳ� ���� �� Ȯ���� ����
            //�ϴ��� ������ �������� �ϰ� ���߿� �����Ѱɷ� �ٲ�ܿ��
        }
        //=> ���
        //1. �̱����� new��� ���� this������� �Ҵ��ؾ��Ѵ� �̹� awake ���� �ν��Ͻ��� ����� �����̴�
        //2. mono behaviour�̳� game object ��ӹ��� �ֵ��� ��� �� new��� ���� instantiate�� �������Ѵ�
        else
        {
            Debug.LogWarning("���� �� �� �̻��� ���� �Ŵ����� �����մϴ�. ");
            Destroy(gameObject); //�ڱ� �ڽ��� ����
        }
    }
    void Update()
    {
        //���⿡�� ���¸� Ž���ϰ� ���¿� ���� �׼��� ���Ѵ�
    }
}
//���� : https://euncero.tistory.com/429
// �ٵ� �̻�� �̻��ϰ��س��� �̱��� ����� �Ƿ��� �̱��� �ν��Ͻ��� �Ҵ��ϴ� ������
//private���� �س��ߵǴµ� public���� �س��� �ܺο��� ���ٰ����ϸ� �̱��� �ȵ��ݾ�