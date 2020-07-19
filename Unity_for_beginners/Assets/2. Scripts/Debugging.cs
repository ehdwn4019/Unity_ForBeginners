using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugging : MonoBehaviour
{
    int score;

    // Start is called before the first frame update
    void Start()
    {
        //Score = 90;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Score = 70;
    }

    void OnMouseDown()
    {
        score = score + 1;
        Debug.Log("마우스를 클릭했습니다 : " + score);
    }
}
