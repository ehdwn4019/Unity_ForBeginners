using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour
{
    Vector3 v3;

    // Start is called before the first frame update
    void Start()
    {
        v3 = new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Rotate(v3);
        //}

        //if(Input.GetButton("Horizontal"))
        //{
        //    transform.Rotate(v3);
        //}

        float h = Input.GetAxis("Horizontal");
        transform.Rotate(v3 * h);
    }
}
