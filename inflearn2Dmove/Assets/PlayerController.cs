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
        //좌우 이동 방향 제어
        moveE.Move(x);

        //플레이어 점프(스페이스 키를 누르면 점프!)
        if(Input.GetKeyDown(KeyCode.Space))
        {
            moveE.Jump();
        }
    }
}
