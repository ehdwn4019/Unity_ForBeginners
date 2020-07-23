using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
  void OnCollisionEnter(Collision obj)
    {
        Debug.Log("충돌 발생");
    }
}
