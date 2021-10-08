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
            uiFirstButton = goFirstButton.GetComponent<Button>(); //변수에 할당 안하고 Update에서 매번 컴포넌트 찾아오기엔 너무 여러번 실행될거같으니까 변수를 선언해서 한번만 초기화해주는 길을 택했다
        if (goSecondOutput != null)
            uiSecondOutput = goSecondOutput.GetComponent<Text>();
        if (goSecondButton != null)
            uiSecondButton = goSecondButton.GetComponent<Button>();


        uiFirstInput.gameObject.SetActive(true);
    }
    void Update()
    {
        //1. first버튼 눌렸을 경우 firstInput의 내용을 secondOutput에 출력
        //2. first버튼 눌렸을 경우 second들 띄우고 first들 감추기
        //3. second버튼 눌렸을 경우 first들 띄우고 second들 감추기
        //4. second버튼 눌렸을 경우 firstInput의 내용 초기화

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

/*<솔루션 탐색기 열기>

visual studio의 솔루션 탐색기는
unity 스크립트 열었을때 알아서 만들어져야됨
하지만 지금은 pro버전을 설치했기에 안되어있음

unity-> file탭->preferences->external tool->script editor을 visual studio pro로 변경

이렇게 해야 특정 클래스 단어들이 색칠되고 그걸 추적해서 따라갈 수 있게 된다*/

/*< Game Object를 UI타입으로 다운캐스팅 할 수 없었던 이유와 기본적인 구조 >

Game Object가 모든것의 상위클래스래서 UI의 상위인줄 알았음
하지만 그게 아니었기 때문에 다운캐스팅도 안되고 as도 안됐던 것이다
Game Object는 Scene에 올리는 애들이 상속받는 것이고 그보다도 상위는 MonoBehaviour임
이 MonoBehaviour을 상속받은 애들을 상속받고 해서 gameObject랑 UI 클래스가 나오는 것이다
MonoBehabiour 클래스는 Awake, Start, Update와 관련이 있는 최상위 클래스고
GameObject는 좌표, rotation을 가지고 씬에 올리는 애들의 상위 클래스임
기본 상속 베이스가 되는 애가 Game Object가 아니라 Mono Behaviour이었던것

그래서 어떤식으로 동작했냐면
GameObject에 컴포넌트들을 부착하는 형식으로 진행됐잖아
이 UI도 컴포넌트에 해당한다
보기에는 같이 나오는것처럼 보여서 헷갈릴 수 있지만
어쨌든 UI는 GameObject를 상속받는게 아니라 그 위에 부착하는거여서 캐스팅 자체가 불가능함
 */

/*< 그래서 결국 어던 방식으로 컴포넌트를 가져와야 하는가? >
 처음에 캐스팅을 하려 했던 이유는 이랬다
1. 확인버튼을 눌렀을때 inputField의 입력값을 가져오려면 변수를 UI 하위 타입으로 선언해야함
2. 그러나 SetActive를 통해 버튼을 토글하려면 변수를 GameObject 타입으로 선언해야함
근데 이 두 역할을 다 하기 때문에 변수를 두번 선언해야 한다는 문제점이 생길것같음
그러므로 한번만 선언한 다음에 다운캐스팅이나 업캐스팅을 해서 요구사항을 충족시켜주자 생각했음
근데 그렇게 작동하질 않았던거지

GO에 컴포넌트를 붙이는 방식으로 작동하기 때문에
선언은 GameObject 타입으로 해놓고 나중에
GetComponent<Button>() 이런식으로 진행해야됨
 */

/*< 올바른 방식으로 진행할때의 주의사항 >
 1. GetComponent<컴포넌트타입>을 실행하기 전에 이 함수를 사용하고자 하는 game object가 null은 아닌지 체크해줘야함
 2. 그런 다음 컴포넌트 가져와서 할당한 변수도 나중에 사용하기 전에 올바르게 가져왔는지 null체크 진행해야됨
 */