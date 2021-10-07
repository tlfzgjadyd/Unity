using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInputMoveEvent : MonoBehaviour
{
    private float moveSpeed = 5.0f;//�̵� �ӵ�
    private Vector3 moveDirection = Vector3.zero; //�̵� ����
    // Start is called before the first frame update

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); //�¿� �̵�, 3D������ �ڵ��ϼ� �̻��ϰ� �Ƿ��ϴµ� �װ� ����� ���� �ƴ϶� vs�� �߸� �ȳ����ذ���
        //Negative left, a : -1
        //Positive right, d : 1
        //Non : 0

        float y = Input.GetAxisRaw("Vertical"); //���Ʒ� �̵�
        //Negative down, s : -1
        //Positive up, w : 1

        //�̵����� ����
        moveDirection = new Vector3(x, y, 0);

        // ���ο� ��ġ = ���� ��ġ + (���� + �ӵ�)
        //transform.position = transform.position + new Vector3(1, 0, 0)*1;

        transform.position += Vector3.right * 1 * Time.deltaTime*moveSpeed;
    }
}/*�� GetAxisRaw��� �Լ��� ����Ƽ�� �̸� ������ ����Ű�� �̿��ϴ� �Լ��̴�
  �� ����Ű�� edit�޴��� project settings�� Input Manager ��� Ȯ�� �����ϴ�
  �ǰ� ���� ���������� �ֳ� ���⿡ ����Ű�� ����� �� �ִٰ� �Ѵ�
  � ������ ���ǳĸ� Horizontal�� ���� ���� ����Ű�� d�� right�� ������ GetAxisRaw�� ����
  float x���� 1�� ��ϵȴ�, ���� ����Ű�� a�� left�� ������ GetAxisRaw�� ���� float y���� -1�� ��ϵȴ�
  �׷��ϱ� �̵���ų�� x, y��� ����ϸ� ��Ȳ�� ���� �ٸ� �̵� �׼��� ���ϰ� �Ǵ� ������!*/
