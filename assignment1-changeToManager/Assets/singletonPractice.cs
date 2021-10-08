using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singletonPractice : MonoBehaviour
{
    //오브젝트에서 자기 자신을 SetActive(false)하는건 동작에 이상이
    //생길 수도 있고 굉장히 이상하므로 외부의 매니저에서 이를 대신 수행해주도록 한다
    //지금은 싱글턴으로 리턴하는것만 한거고
    //원래는 제어할 다른 오브젝트들을 변수로 가지고 있어야 한다
    private static singletonPractice instance; // 싱글턴을 할당할 변수라는데 이사람은 public으로 해놨지만
                                                //내가 배운걸로도 그렇고 다른사람 코드도 그렇고 private이 맞다
                                                 //안그럼 외부에서 접근 가능해져서 싱글톤이 제대로 안되잖아
    //이때 중요한건 해당 변수의 타입이 지금 작성하고 있는 이 클래스와 일치해야한다는 점이다
    //이거 자체는 비어있고 제어만 하는 오브젝트라 그런가

    //게임 시작과 동시에 싱글턴 구성
    void Awake()
    {
        if(instance ==null)
        {
            instance = this;//오 뭐지 새로운거 생성을 안한건가
            //c++레퍼런스 클래스 안에서 클래스의 인스턴스를 스스로 지칭할때
            //this하고 operator()정의안돼있어서 안됨 일반적으론 
            //instance = this(); 이거는 에러나는데
            //instance = new singletonPractice();//일반 c#이면 이렇게해야하는데 지금은 유니티 안에 있는데
            //모노behaviour상속받았고 awake에 들어왔으니까 이미 인스턴스가 생성됐음 
            //그래서 이미 생겨있기에 this가 할당돼있기 때문에 또 만들지x
            //저거 상속받은 애들 다 그렇다 일반적인 모노저걸 상속받았거나 게임 오브젝트 상속받은 애들은
            //다 instantiate로 만든다

            //싱글톤은 더 복잡하게 들어갈때도 있음 어떤건 스레드 환경 고려 락잡을수도 있음
            //싱글턴 많이 쓰기 때문에 우리팀 안에서 공식적으로 싱글턴 하나 만들어서 쓸 확률이 높음
            //일단한 간단한 버전으로 하고 나중에 복잡한걸로 바꿔외운다
        }
        //=> 결론
        //1. 싱글턴은 new방식 말고 this방식으로 할당해야한다 이미 awake 전에 인스턴스가 생겼기 때문이다
        //2. mono behaviour이나 game object 상속받은 애들의 경우 다 new방식 말고 instantiate로 만들어야한다
        else
        {
            Debug.LogWarning("씬에 두 개 이상의 게임 매니저가 존재합니다. ");
            Destroy(gameObject); //자기 자신을 삭제
        }
    }
    void Update()
    {
        //여기에서 상태를 탐지하고 상태에 따른 액션을 취한다
    }
}
//참고 : https://euncero.tistory.com/429
// 근데 이사람 이상하게해놨음 싱글톤 제대로 되려면 싱글톤 인스턴스를 할당하는 변수를
//private으로 해놔야되는데 public으로 해놨음 외부에서 접근가능하면 싱글톤 안되잖아
