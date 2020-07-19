using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        print("마우스가 들어왔습니다");
    }

    void OnMouseExit()
    {
        print("마우스가 나갔습니다");
    }

    void OnMouseDown()
    {
        print("마우스 버튼을 클릭했습니다");
    }

    void OnMouseUp()
    {
        print("마우스 버튼이 떨어졌습니다");
    }
}
