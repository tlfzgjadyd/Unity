using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private moveEvent moveE;

    private void Awake()
    {
        moveE = GetComponent<moveEvent>();
    }

    private void Update()
    {
        //left or a = -1 / right or d = 1
        float x = Input.GetAxisRaw("Horizontal");
        //�¿� �̵� ���� ����
        moveE.Move(x);

        //�÷��̾� ����(�����̽� Ű�� ������ ����!)
        if(Input.GetKeyDown(KeyCode.Space))
        {
            moveE.Jump();
        }
    }
}
