using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class integratedFirstInputEvent : MonoBehaviour
{
    public InputField integratedFirstInput;
    public Button integratedFirstButton;

    // Start is called before the first frame update
    void Start()
    {
        integratedFirstButton.onClick.AddListener(() => //확인버튼이 눌리는 것을 감지하기 위해 리스너를 달았다
        {
            if (integratedFirstInput.text != null)
                Debug.Log(integratedFirstInput.text);
        });
    }

    // Update is called once per frame
    void Update()
    {

    }
}
