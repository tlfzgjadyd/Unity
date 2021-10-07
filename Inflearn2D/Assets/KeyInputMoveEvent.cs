using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//2D�� �����̰��ϱ�
public class KeyInputMoveEvent : MonoBehaviour
{
    private float moveSpeed = 5.0f;//�̵� �ӵ�
    private Vector3 moveDirection = Vector3.zero; //�̵� ����
    private Rigidbody2D rigid2D;
    // Start is called before the first frame update

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>(); 
    }

    private void Update()
    {

        float x = Input.GetAxisRaw("Horizontal"); //�¿� �̵�
        //Negative left, a : -1
        //Positive right, d : 1
        //Non : 0

        float y = Input.GetAxisRaw("Vertical"); //���Ʒ� �̵�
        //Negative down, s : -1
        //Positive up, w : 1
        //Non : 0

        rigid2D.velocity = new Vector3(x, y, 0) * moveSpeed;
        //�̵����� ����
        moveDirection = new Vector3(x, y, 0);

        // ���ο� ��ġ = ���� ��ġ + (���� + �ӵ�)
        //transform.position = transform.position + new Vector3(1, 0, 0)*1;

        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}/*�� GetAxisRaw��� �Լ��� ����Ƽ�� �̸� ������ ����Ű�� �̿��ϴ� �Լ��̴�
  �� ����Ű�� edit�޴��� project settings�� Input Manager ��� Ȯ�� �����ϴ�
  �ǰ� ���� ���������� �ֳ� ���⿡ ����Ű�� ����� �� �ִٰ� �Ѵ�
  � ������ ���ǳĸ� Horizontal�� ���� ���� ����Ű�� d�� right�� ������ GetAxisRaw�� ����
  float x���� 1�� ��ϵȴ�, ���� ����Ű�� a�� left�� ������ GetAxisRaw�� ���� float y���� -1�� ��ϵȴ�
  �׷��ϱ� �̵���ų�� x, y��� ����ϸ� ��Ȳ�� ���� �ٸ� �̵� �׼��� ���ϰ� �Ǵ� ������!*/

//�ٵ� ������ 3D������ �ȸ����ٴ� ���̴� 
//�Ȱ��� �ڵ�� �غôµ� 3D������Ʈ������ �ƿ� Input�� �ٸ��ɷ� �ڵ��ϼ��Ƿ��ϰ�
//����� �۵������� �ʾ��� �׷��� 2D �����̶��ǵ� �׷� �ǹ̰� �ֳ�
