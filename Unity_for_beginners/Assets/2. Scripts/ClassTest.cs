using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassTest : MonoBehaviour
{
    
    public int score;
    public float height;
    bool yesno;
    string str;

    // Start is called before the first frame update
    void Start()
    {
        score = 90;
        height = 178.5f;
        yesno = true;
        str = "자료형 테스트입니다";
    }

    // Update is called once per frame
    void Update()
    {
        print("score : " + score);
        print("height : " + height);
        print("yesno : " + yesno);
        print("str : " + str);
    }
}
