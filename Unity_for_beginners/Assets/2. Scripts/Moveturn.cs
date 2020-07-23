using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveturn : MonoBehaviour
{
    Vector3 forward = new Vector3(0, 0, 1);
    Vector3 up = new Vector3(0, 1, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        v = v * Time.deltaTime;
        h = h * Time.deltaTime;

        transform.Translate(forward * v * 20);
        transform.Rotate(up * h * 120);
    }
}
