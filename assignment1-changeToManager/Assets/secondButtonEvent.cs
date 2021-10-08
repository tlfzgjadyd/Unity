using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;//이거랑

public class secondButtonEvent : MonoBehaviour, IPointerClickHandler//이거랑
{
    public GameObject firstInput;
    public GameObject firstButton;
    public GameObject secondOutput;
    public GameObject secondButton;

    public void OnPointerClick(PointerEventData eventData)//여기서 PointerEventData타입의 eventData가 있어줘야 밑에서 리스닝 가능하다 그리고 이건 IPointerClickHadler를 상속받아야 쓸 수 있음 그리고 겉에 이 OnPointerclick 함수로 감싸줘야한다!!
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log("띄우고 숨기기 토글하는 버튼이 마우스 왼쪽버튼으로 눌렸다");
            toggle();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if(secondOutput!=null) //gameObject의 함수를 사용하는 경우 항상 null 체크를 진행해줘야한다
            secondOutput.SetActive(false);
        if(secondButton!=null)//gameObject의 함수를 사용하는 경우 항상 null 체크를 진행해줘야한다
            secondButton.SetActive(false);
    }

    public void toggle()
    {
        if(firstInput!=null)
            firstInput.SetActive(true);
        if (firstButton != null)
            firstButton.SetActive(true);
        if (secondOutput != null)
            secondOutput.SetActive(false);
        if (secondButton != null)
            secondButton.SetActive(false);
        //this.SetActive(false); //이렇게 하면 아예 작동을 안한다 왜냐하면 this는 눌린 버튼이 아니라 버튼 이벤트에 해당하기 때문이다
                                 //그냥 Event의 경우 위에 보이듯이 MonoBehaviour만을 상속받는데 MonoBehaviour은 game object가 가지고 있는 SetActive 등의 함수가 없음
        //gameObject.SetActive(true); //이렇게 하면 되기는 하는데 너무 넓은 범위로 진행돼버림 

        /*근데 기본적으로 자기자신을 SetActive 꺼버리는 경우 안의 함수들 등으로 문제가 생길 수도 있기 때문에 
         스스로 끄기보다는 매니저를 하나 둬서 껐다켰다 하는 것이 좋다*/

        /*아이디 순회 방식은 잘 안써야한다
         id이름을 쓰는 경우는 굉장히 드물어야한다
         이름이 바뀌기도 쉽고 비슷한 이름도 많기 때문이다
        id 이름으로 검색하는 경우 모든 오브젝트들 내에서 순회로 찾아야해서 비용이 매우 비싸짐
        그렇기때문에 스크립트에 변수 만들고 연동해서 쓰는 방식이 좋다
        
        find object도 이러한 이유로 가능은 한데 비용이 너무 크다
        그래서 여러번 수행되는 update내에는 절대로 써선 안되며
        버튼 눌렀을때 한번정도 찾는것에는 가끔 써도 되긴 함
        대신 모든걸 찾지 말고 버튼들 중에서만 찾아라 이런 방식으로 진행해야한다
        이건 따로 찾아볼것
         */
    }
}
