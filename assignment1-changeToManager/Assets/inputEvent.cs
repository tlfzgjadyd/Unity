using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //�̰� �ʿ���

public class inputEvent : MonoBehaviour
{
    public InputField m_InputField;//�� �� input�̺�Ʈ ó���Ҷ��� gameobject�� �ƴ϶� inputfield�� button���� ó���ؾ��߱���
    public Button m_Button;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("�����Ϸ�");
        m_Button.onClick.AddListener(() => //Ȯ�ι�ư�� ������ ���� �����ϱ� ���� �����ʸ� �޾Ҵ�
        {
            if (m_InputField.text != null)
                Debug.Log(m_InputField.text);
        });
    }

    // Update is called once per frame
    void Update()
    {

    }
}
//�ϴ� inspector���� ��ũ��Ʈ�� input Field ������ ä���ִϱ� ������ �ȳ��µ�
//input UI�� ��� 2���� ������ ����
/* 
 * On Value Changed�� ��ȭ �Ͼ �� ���� ����Ǵ°Ű�
 * On End Edit�� �Է� ������ �ѹ� �����
 */

//�ڵ忡 ;�����ų� �ؼ� ���� �����̶� ������ inspectorâ�� �ȶߴ� �͵��� �����
//�̹��� ��ư ���� �ȶ� ������ �̰Ͷ�����

//�۵������ 1. UI��ü ����
//2. ��ũ��Ʈ ����� ��ü�� ����
//3. ��ũ��Ʈ ���� ������ ����� �ڵ忡 ������ ���� ��� ��ü�� inspectorâ�� �� ������ ��ü�� �����ش޶�� �߰Ե� �װ� �巡���ϰų� ���� ��ư ������ ��������

//4. ���⿡ �߰��� inputâ, Ȯ��â�� ��� input�� ��ũ��Ʈ�ʿ��� ��ư �����ʷ� ��ư Ŭ���Ǵ°� ����ִٰ� �ؽ�Ʈ�� ����ϰų� ������ ����ߵ�