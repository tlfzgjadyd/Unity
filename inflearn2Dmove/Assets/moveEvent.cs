using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveEvent : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f; //�̵� �ӵ�
    [SerializeField]
    private float jumpForce = 25.0f; //���� �� (Ŭ���� ���� ����)
    private Rigidbody2D rigid2D;

    [SerializeField]
    private LayerMask groundLayer; //�ٴ� üũ�� ���� �浹 ���̾�
    private CapsuleCollider2D capsulecollider2D; //������Ʈ�� �浹 ���� ������Ʈ
    private bool isGrounded; //�ٴ� üũ(�ٴڿ� ������� �� true)
    private Vector3 footPosition; //���� ��ġ

    [SerializeField]
    private int maxJumpcount = 2; //���� ��� ������ �� �� �ִ� �ִ� ���� Ƚ��
    private int currentJumpCount = 0; //���� ������ ���� Ƚ��

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        capsulecollider2D = GetComponent<CapsuleCollider2D>();
    }
    private void FixedUpdate()
    {
        //�÷��̾� ������Ʈ�� Collider2D min, center, max ��ġ ����
        Bounds bounds = capsulecollider2D.bounds;
        //�÷��̾��� �� ��ġ ����
        footPosition = new Vector2(bounds.center.x, bounds.min.y);
        //�÷��̾��� �� ��ġ�� ���� �����ϰ�, ���� �ٴڰ� ��������� isGrounded = true;
        isGrounded = Physics2D.OverlapCircle(footPosition, 0.1f, groundLayer);

        if(isGrounded ==true && rigid2D.velocity.y <=0)
        {
            currentJumpCount = maxJumpcount;
        }
    }
    public void Move(float x)
    {
        //x�� �̵��� X * speed��, y�� �̵��� ������ �ӷ°�(����� �߷�)
        rigid2D.velocity = new Vector2(x * speed, rigid2D.velocity.y);
    }
    public void Jump()
    {
        //if(isGrounded == true) //�ٴ� ��� �������� ���� Ȱ��ȭ
        if(currentJumpCount>0)
        {
            //jumpForce�� ũ�⸸ŭ ���� �������� �ӷ� ����
            rigid2D.velocity = Vector2.up * jumpForce;
            currentJumpCount--;
        }
        
    }
}
