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
        integratedFirstButton.onClick.AddListener(() => //Ȯ�ι�ư�� ������ ���� �����ϱ� ���� �����ʸ� �޾Ҵ�
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
