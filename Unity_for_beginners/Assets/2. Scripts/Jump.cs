using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetButton("Jump"))
        //{
        //    GetComponent<Rigidbody>().AddForce(new Vector3(0, 80, 0));
        //}

        if (Input.GetButton("Jump"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 80, 0);
        }
    }
}
