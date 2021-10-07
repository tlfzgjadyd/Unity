using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveEvent : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f; //이동 속도
    [SerializeField]
    private float jumpForce = 25.0f; //점프 힘 (클수록 높게 점프)
    private Rigidbody2D rigid2D;

    [SerializeField]
    private LayerMask groundLayer; //바닥 체크를 위한 충돌 레이어
    private CapsuleCollider2D capsulecollider2D; //오브젝트의 충돌 범위 컴포넌트
    private bool isGrounded; //바닥 체크(바닥에 닿아있을 때 true)
    private Vector3 footPosition; //발의 위치

    [SerializeField]
    private int maxJumpcount = 2; //땅을 밟기 전까지 할 수 있는 최대 점프 횟수
    private int currentJumpCount = 0; //현재 가능한 점프 횟수

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        capsulecollider2D = GetComponent<CapsuleCollider2D>();
    }
    private void FixedUpdate()
    {
        //플레이어 오브젝트의 Collider2D min, center, max 위치 정보
        Bounds bounds = capsulecollider2D.bounds;
        //플레이어의 발 위치 설정
        footPosition = new Vector2(bounds.center.x, bounds.min.y);
        //플레이어의 발 위치에 원을 생성하고, 원이 바닥과 닿아있으며 isGrounded = true;
        isGrounded = Physics2D.OverlapCircle(footPosition, 0.1f, groundLayer);

        if(isGrounded ==true && rigid2D.velocity.y <=0)
        {
            currentJumpCount = maxJumpcount;
        }
    }
    public void Move(float x)
    {
        //x축 이동은 X * speed로, y축 이동은 기존의 속력값(현재는 중력)
        rigid2D.velocity = new Vector2(x * speed, rigid2D.velocity.y);
    }
    public void Jump()
    {
        //if(isGrounded == true) //바닥 밟고 있을때만 점프 활성화
        if(currentJumpCount>0)
        {
            //jumpForce의 크기만큼 윗쪽 방향으로 속력 설정
            rigid2D.velocity = Vector2.up * jumpForce;
            currentJumpCount--;
        }
        
    }
}
