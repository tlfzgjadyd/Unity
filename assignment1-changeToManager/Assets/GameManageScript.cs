using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManageScript : MonoBehaviour
{
    private GameManageScript gameMavageScript;

    public GameObject goFirstInput;
    public GameObject goFirstButton;
    public GameObject goSecondOutput;
    public GameObject goSecondButton;

    public InputField uiFirstInput;
    public Button uiFirstButton;
    public Text uiSecondOutput;
    public Button uiSecondButton;

    void Awake()
    {
        if (gameMavageScript == null)
        {
            gameMavageScript = this;
        }
        else
        {
            Debug.LogWarning("Game Manager Singleton Error");
        }
        if (goFirstInput != null)
            uiFirstInput = goFirstInput.GetComponent<InputField>();
        if (goFirstButton != null)
            uiFirstButton = goFirstButton.GetComponent<Button>(); //������ �Ҵ� ���ϰ� Update���� �Ź� ������Ʈ ã�ƿ��⿣ �ʹ� ������ ����ɰŰ����ϱ� ������ �����ؼ� �ѹ��� �ʱ�ȭ���ִ� ���� ���ߴ�
        if (goSecondOutput != null)
            uiSecondOutput = goSecondOutput.GetComponent<Text>();
        if (goSecondButton != null)
            uiSecondButton = goSecondButton.GetComponent<Button>();


        uiFirstInput.gameObject.SetActive(true);
    }
    void Update()
    {
        //1. first��ư ������ ��� firstInput�� ������ secondOutput�� ���
        //2. first��ư ������ ��� second�� ���� first�� ���߱�
        //3. second��ư ������ ��� first�� ���� second�� ���߱�
        //4. second��ư ������ ��� firstInput�� ���� �ʱ�ȭ

        //1. 2.
        if (uiFirstButton != null)
        {
            uiFirstButton.onClick.AddListener(() =>
            {
                if ((uiFirstInput != null) && (uiSecondOutput != null))
                    uiSecondOutput.text = uiFirstInput.text;

                goFirstInput.SetActive(false);
                goFirstButton.SetActive(false);
                goSecondOutput.SetActive(true);
                goSecondButton.SetActive(true);
            });
        }
        //3.
        if (uiSecondButton != null)
        {
            uiSecondButton.onClick.AddListener(() =>
            {
                if (uiFirstInput != null)
                    uiFirstInput.text = "";
                goFirstInput.SetActive(true);
                goFirstButton.SetActive(true);
                goSecondOutput.SetActive(false);
                goSecondButton.SetActive(false);
            });
        }

    }
}

/*<�ַ�� Ž���� ����>

visual studio�� �ַ�� Ž�����
unity ��ũ��Ʈ �������� �˾Ƽ� ��������ߵ�
������ ������ pro������ ��ġ�߱⿡ �ȵǾ�����

unity-> file��->preferences->external tool->script editor�� visual studio pro�� ����

�̷��� �ؾ� Ư�� Ŭ���� �ܾ���� ��ĥ�ǰ� �װ� �����ؼ� ���� �� �ְ� �ȴ�*/

/*< Game Object�� UIŸ������ �ٿ�ĳ���� �� �� ������ ������ �⺻���� ���� >

Game Object�� ������ ����Ŭ�������� UI�� �������� �˾���
������ �װ� �ƴϾ��� ������ �ٿ�ĳ���õ� �ȵǰ� as�� �ȵƴ� ���̴�
Game Object�� Scene�� �ø��� �ֵ��� ��ӹ޴� ���̰� �׺��ٵ� ������ MonoBehaviour��
�� MonoBehaviour�� ��ӹ��� �ֵ��� ��ӹް� �ؼ� gameObject�� UI Ŭ������ ������ ���̴�
MonoBehabiour Ŭ������ Awake, Start, Update�� ������ �ִ� �ֻ��� Ŭ������
GameObject�� ��ǥ, rotation�� ������ ���� �ø��� �ֵ��� ���� Ŭ������
�⺻ ��� ���̽��� �Ǵ� �ְ� Game Object�� �ƴ϶� Mono Behaviour�̾�����

�׷��� ������� �����߳ĸ�
GameObject�� ������Ʈ���� �����ϴ� �������� ������ݾ�
�� UI�� ������Ʈ�� �ش��Ѵ�
���⿡�� ���� �����°�ó�� ������ �򰥸� �� ������
��·�� UI�� GameObject�� ��ӹ޴°� �ƴ϶� �� ���� �����ϴ°ſ��� ĳ���� ��ü�� �Ұ�����
 */

/*< �׷��� �ᱹ ��� ������� ������Ʈ�� �����;� �ϴ°�? >
 ó���� ĳ������ �Ϸ� �ߴ� ������ �̷���
1. Ȯ�ι�ư�� �������� inputField�� �Է°��� ���������� ������ UI ���� Ÿ������ �����ؾ���
2. �׷��� SetActive�� ���� ��ư�� ����Ϸ��� ������ GameObject Ÿ������ �����ؾ���
�ٵ� �� �� ������ �� �ϱ� ������ ������ �ι� �����ؾ� �Ѵٴ� �������� ����Ͱ���
�׷��Ƿ� �ѹ��� ������ ������ �ٿ�ĳ�����̳� ��ĳ������ �ؼ� �䱸������ ������������ ��������
�ٵ� �׷��� �۵����� �ʾҴ�����

GO�� ������Ʈ�� ���̴� ������� �۵��ϱ� ������
������ GameObject Ÿ������ �س��� ���߿�
GetComponent<Button>() �̷������� �����ؾߵ�
 */

/*< �ùٸ� ������� �����Ҷ��� ���ǻ��� >
 1. GetComponent<������ƮŸ��>�� �����ϱ� ���� �� �Լ��� ����ϰ��� �ϴ� game object�� null�� �ƴ��� üũ�������
 2. �׷� ���� ������Ʈ �����ͼ� �Ҵ��� ������ ���߿� ����ϱ� ���� �ùٸ��� �����Դ��� nullüũ �����ؾߵ�
 */