using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGUITest : MonoBehaviour
{
    GameObject cube;
    string str = "";

    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        if(GUI.RepeatButton(new Rect(80,30,60,40)," ^ "))
        {
            str = "위로 이동합니다.";
            cube.transform.Translate(Vector3.up * 0.1f);
        }
        if (GUI.RepeatButton(new Rect(10, 80, 60, 40), " < "))
        {
            str = "왼쪽으로 이동합니다.";
            cube.transform.Translate(Vector3.left * 0.1f);
        }
        if (GUI.RepeatButton(new Rect(150, 80, 60, 40), " > "))
        {
            str = "오른쪽으로 이동합니다.";
            cube.transform.Translate(Vector3.right * 0.1f);
        }
        if (GUI.RepeatButton(new Rect(80, 130, 60, 40), " v "))
        {
            str = "아래로 이동합니다.";
            cube.transform.Translate(Vector3.down * 0.1f);
        }

        GUILayout.Label(str);
    }
}
