using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInputMoveEvent : MonoBehaviour
{
    private float moveSpeed = 5.0f;//이동 속도
    private Vector3 moveDirection = Vector3.zero; //이동 방향
    // Start is called before the first frame update

    void Update()
    {

        float x = Input.GetAxisRaw("Horizontal"); //좌우 이동
        //Negative left, a : -1
        //Positive right, d : 1
        //Non : 0

        float y = Input.GetAxisRaw("Vertical"); //위아래 이동
        //Negative down, s : -1
        //Positive up, w : 1

        //이동방향 설정
        moveDirection = new Vector3(x, y, 0);

        // 새로운 위치 = 현재 위치 + (방향 + 속도)
        //transform.position = transform.position + new Vector3(1, 0, 0)*1;

        transform.position += Vecto3.right * 1 * Time.deltaTime+moveSpeed;
    }
}/*이 GetAxisRaw라는 함수는 유니티에 미리 설정된 단축키를 이용하는 함수이다
  이 단축키는 edit메뉴에 project settings에 Input Manager 열어서 확인 가능하대
  되게 뭐야 여러가지가 있네 여기에 단축키를 등록할 수 있다고 한다
  어떤 원리로 사용되냐면 Horizontal에 대해 긍정 단축키인 d나 right를 누르면 GetAxisRaw에 의해
  float x에는 1이 등록된다, 부정 단축키인 a나 left를 누르면 GetAxisRaw에 의해 float y에는 -1이 등록된다
  그러니까 이동시킬때 x, y라고 등록하면 상황에 따라 다른 이동 액션을 취하게 되는 것이지!*/
